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
        Task<List<BlogResponse>> GetAllBlogs();
        Task<BlogResponse> GetBlogById(string id);
        Task<List<BlogResponse>> GetBlogByTitle(string title);
        Task<BlogResponse> CreateBlogsAsync(CreateBlogRequest createBlogRequest);
        Task<BlogResponse> UpdateBlogsAsync(string id, CreateBlogRequest request);
        Task<bool> DeleteBlogsAsync(string id);
    }
}
