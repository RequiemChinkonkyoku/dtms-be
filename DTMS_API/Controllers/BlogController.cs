using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Blog;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Route("api/blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("get-all-blogs")]
        public async Task<IActionResult> GetAllBlogs()
        {
            var response = await _blogService.GetAllBlogs();
            return Ok(response);
        }

        [HttpGet("get-blog-by-id/{id}")]
        public async Task<IActionResult> GetBlogById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var blog = await _blogService.GetBlogById(id);
                if (blog == null)
                    return NotFound("Blog not found.");
                return Ok(blog);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("get-blog-by-title/{title}")]
        public async Task<IActionResult> GetBlogByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return BadRequest("Title is required.");
            try
            {
                var blog = await _blogService.GetBlogByTitle(title);
                if (blog == null)
                    return NotFound("Blog not found.");
                return Ok(blog);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("create-blogs")]
        public async Task<IActionResult> CreateBlogs([FromBody] CreateBlogRequest request)
        {
            if (request == null)
                return BadRequest("Request is required.");
            try
            {
                var blog = await _blogService.CreateBlogsAsync(request);
                return Ok(blog);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("update-blogs/{id}")]
        public async Task<IActionResult> UpdateBlogs(string id, [FromBody] CreateBlogRequest request)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            if (request == null)
                return BadRequest("Request is required.");
            try
            {
                var blog = await _blogService.UpdateBlogsAsync(id, request);
                return Ok(blog);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("delete-blogs/{id}")]
        public async Task<IActionResult> DeleteBlogs(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var result = await _blogService.DeleteBlogsAsync(id);
                if (!result)
                    return NotFound("Blog not found.");
                return Ok("Blog deleted successfully.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
