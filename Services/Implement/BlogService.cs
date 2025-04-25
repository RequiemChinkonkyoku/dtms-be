using AutoMapper;
using Models.DTOs;
using Models.DTOs.Blog;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implement
{
    public class BlogService : IBlogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<BlogResponse>> GetAllBlogs()
        {
            var result = await _unitOfWork.Blogs.GetAll();
            var response =  _mapper.Map<List<BlogResponse>>(result);
            return new BaseResponseDTO<BlogResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<BlogResponse>> GetBlogById(string id)
        {
            var result = await _unitOfWork.Blogs.GetById(id);

            if (result == null)
            {
                return new BaseResponseDTO<BlogResponse> { Success = false, Message = "Unable to find blog with id " + id };
            }

            var response =  _mapper.Map<BlogResponse>(result);
            return new BaseResponseDTO<BlogResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<BlogResponse>> GetBlogByTitle(string title)
        {
            var result = await _unitOfWork.Blogs.Get(c => c.Title.Contains(title));

            if (result == null)
            {
                return new BaseResponseDTO<BlogResponse> { Success = false, Message = "Unable to find blog with title " + title };
            }

            var response =  _mapper.Map<List<BlogResponse>>(result);
            return new BaseResponseDTO<BlogResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<BlogResponse>> CreateBlogsAsync(CreateBlogRequest createBlogRequest)
        {
            if (string.IsNullOrWhiteSpace(createBlogRequest.StaffProfileId))
            {
                throw new ArgumentException("StaffProfileId is required.");
            }

            var staffProfileId = await _unitOfWork.Accounts.GetById(createBlogRequest.StaffProfileId);
            if (staffProfileId == null)
            {
                throw new KeyNotFoundException("StaffProfileId is not valid.");
            }

            var staffRole = await _unitOfWork.Roles.GetById(staffProfileId.RoleId);
            if (staffRole == null)
            {
                throw new KeyNotFoundException("StaffProfileId is not valid.");
            }
            if (staffRole.Name != "Staff_Manager" && staffRole.Name != "Staff_Employee")
            {
                throw new ArgumentException("StaffProfileId is not a staff.");
            }

            var blog = _mapper.Map<Blog>(createBlogRequest);

            blog.Status = 0;
            blog.TimePublished = DateTime.UtcNow;
            blog.StaffId = createBlogRequest.StaffProfileId;

            await _unitOfWork.Blogs.Add(blog);
            await _unitOfWork.SaveChanges();

            var response =  _mapper.Map<BlogResponse>(blog);
            return new BaseResponseDTO<BlogResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<BlogResponse>> UpdateBlogsAsync(string id, CreateBlogRequest request)
        {
            var existingBlog = await _unitOfWork.Blogs.GetById(id);

            if (existingBlog == null)
            {
                throw new KeyNotFoundException($"Blog not found.");
            }

            if (string.IsNullOrWhiteSpace(request.StaffProfileId))
            {
                throw new ArgumentException("StaffProfileId is required.");
            }

            var staffProfileId = await _unitOfWork.Accounts.GetById(request.StaffProfileId);
            if (staffProfileId == null)
            {
                throw new KeyNotFoundException("StaffProfileId is not valid.");
            }

            var staffRole = await _unitOfWork.Roles.GetById(staffProfileId.RoleId);
            if (staffRole == null)
            {
                throw new KeyNotFoundException("StaffProfileId is not valid.");
            }
            if (staffRole.Name != "Staff_Manager" && staffRole.Name != "Staff_Employee")
            {
                throw new ArgumentException("StaffProfileId is not a staff.");
            }

            _mapper.Map(request, existingBlog);

            existingBlog.LastUpdatedTime = DateTime.UtcNow;
            existingBlog.StaffId = request.StaffProfileId;

            _unitOfWork.Blogs.Update(existingBlog);
            await _unitOfWork.SaveChanges();

            var response =  _mapper.Map<BlogResponse>(existingBlog);
            return new BaseResponseDTO<BlogResponse> { Success = true, Object = response };
        }

        public async Task<bool> DeleteBlogsAsync(string id)
        {
            var existingBlog = await _unitOfWork.Blogs.GetById(id);

            if (existingBlog == null)
            {
                throw new KeyNotFoundException($"Blog not found.");
            }

            _unitOfWork.Blogs.Delete(existingBlog);
            await _unitOfWork.SaveChanges();

            return true;
        }
        
        public async Task<BaseResponseDTO<BlogResponse>> PublishBlogAsync(string id)
        {
            var blog = await _unitOfWork.Blogs.GetById(id);
            if (blog == null)
            {
                return new BaseResponseDTO<BlogResponse>
                {
                    Success = false,
                    Message = "Blog not found."
                };
            }

            if (blog.Status == 1)
            {
                return new BaseResponseDTO<BlogResponse>
                {
                    Success = false,
                    Message = "Blog is already published."
                };
            }

            blog.Status = 1;
            blog.TimePublished = DateTime.UtcNow;
            blog.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.Blogs.Update(blog);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<BlogResponse>(blog);
            return new BaseResponseDTO<BlogResponse>
            {
                Success = true,
                Message = "Blog published successfully.",
                Object = response
            };
        }

    }
}
