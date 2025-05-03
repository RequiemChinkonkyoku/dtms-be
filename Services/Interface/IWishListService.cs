using Models.DTOs;
using Models.DTOs.Wishlist.Request;
using Models.DTOs.Wishlist.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IWishListService
    {
        Task<BaseResponseDTO<GetWishlistResponse>> GetAll();
        Task<BaseResponseDTO<GetWishlistResponse>> GetWishListById(string id);
        Task<BaseResponseDTO<GetWishlistResponse>> GetWishListByCourseId(string id);
        Task<BaseResponseDTO<WishList>> CreateWishList(CreateWishListRequest request);
        Task<BaseResponseDTO<WishList>> DeleteWishList(string id);
    }
}
