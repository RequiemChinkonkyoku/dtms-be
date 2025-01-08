

using Microsoft.AspNetCore.Http;

namespace Services.Interface
{
    public interface ICloudinaryService
    {
        Task<string> UploadFile(IFormFile file);
    }
}
