using Models.DTOs;
using Models.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IBlogService
    {
        Task<BaseResponseDTO<BlogResponse>> GetAllBlogs();
        Task<BaseResponseDTO<BlogResponse>> GetBlogById(string id);
        Task<BaseResponseDTO<BlogResponse>> GetBlogByTitle(string title);
        Task<BaseResponseDTO<BlogResponse>> CreateBlogsAsync(CreateBlogRequest createBlogRequest);
        Task<BaseResponseDTO<BlogResponse>> UpdateBlogsAsync(string id, CreateBlogRequest request);
        Task<bool> DeleteBlogsAsync(string id);
        Task<BaseResponseDTO<BlogResponse>> PublishBlogAsync(string id);
    }
}
