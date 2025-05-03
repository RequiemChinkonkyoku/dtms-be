using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Models.DTOs.Wishlist.Request;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/wishlists")]
    public class WishlistController : ControllerBase
    {
        private readonly IWishListService _wishListService;

        public WishlistController(IWishListService wishListService)
        {
            _wishListService = wishListService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWishLists()
        {
            var response = await _wishListService.GetAll();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWishListById(string id)
        {
            var response = await _wishListService.GetWishListById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateWishList(CreateWishListRequest request)
        {
            var response = await _wishListService.CreateWishList(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWishList(string id)
        {
            var response = await _wishListService.DeleteWishList(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("courseId/{id}")]
        public async Task<IActionResult> GetWishListByCourseId(string id)
        {
            var response = await _wishListService.GetWishListByCourseId(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
