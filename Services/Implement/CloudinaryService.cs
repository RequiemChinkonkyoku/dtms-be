using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Services.Interface;
using Services.Setting;

namespace Services.Implement
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;
        private readonly CloudinarySetting _cloudinarySetting;

        public CloudinaryService(IOptions<CloudinarySetting> cloudinarySetting)
        {
            _cloudinarySetting = cloudinarySetting.Value;
            var account = new Account(
                        _cloudinarySetting.CloudName,
                        _cloudinarySetting.ApiKey,
                        _cloudinarySetting.SecretKey);

             _cloudinary = new Cloudinary(account);
        }


        public async Task<string> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("File is empty or null");

            var uploadResult = new ImageUploadResult();

            await using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, stream),
                Transformation = new Transformation().Quality(80).Crop("limit")
            };

            uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
                throw new Exception(uploadResult.Error.Message);

            return uploadResult.SecureUrl.ToString(); 
        }
    }
    
}
