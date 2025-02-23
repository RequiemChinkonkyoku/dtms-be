using AutoMapper;
using CloudinaryDotNet;
using Models.DTOs;
using Models.DTOs.Blog;
using Models.DTOs.Certification;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var staffProfileId = await _unitOfWork.StaffProfiles.GetById(createBlogRequest.StaffProfileId);
            if (staffProfileId == null)
            {
                throw new KeyNotFoundException("StaffProfileId is not valid.");
            }

            var blog = _mapper.Map<Blog>(createBlogRequest);

            blog.Status = 1;
            blog.TimePublished = DateTime.UtcNow;

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

            var staffProfileId = await _unitOfWork.StaffProfiles.GetById(request.StaffProfileId);
            if (staffProfileId == null)
            {
                throw new KeyNotFoundException("StaffProfileId is not valid.");
            }

            _mapper.Map(request, existingBlog);

            existingBlog.LastUpdatedTime = DateTime.UtcNow;

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
    }
}
