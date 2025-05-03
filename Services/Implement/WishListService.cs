using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Tokens;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Class;
using Models.DTOs.Wishlist.Request;
using Models.DTOs.Wishlist.Response;
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
    public class WishListService : IWishListService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WishListService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<GetWishlistResponse>> GetAll()
        {
            var response = await _unitOfWork.WishLists.GetAllWishLists();

            var mappedRResponse = _mapper.Map<List<GetWishlistResponse>>(response);

            return new BaseResponseDTO<GetWishlistResponse> { Success = true, ObjectList = mappedRResponse };
        }

        public async Task<BaseResponseDTO<GetWishlistResponse>> GetWishListById(string id)
        {
            var wishlist = await _unitOfWork.WishLists.GetWishListById(id);

            if (wishlist == null)
            {
                return new BaseResponseDTO<GetWishlistResponse>
                {
                    Success = false,
                    Message = $"Unable to find wishlist with id {id}."
                };
            }

            var mappedResponse = _mapper.Map<GetWishlistResponse>(wishlist);

            var openClass = (await _unitOfWork.Classes.GetAll())
                                        .FirstOrDefault(c => c.CourseId == wishlist.CourseId &&
                                                             c.Status == (int)ClassStatusEnum.Active);

            if (openClass != null)
            {
                mappedResponse.OpenClass = true;
            }

            return new BaseResponseDTO<GetWishlistResponse> { Success = true, Object = mappedResponse };
        }

        public async Task<BaseResponseDTO<WishList>> CreateWishList(CreateWishListRequest request)
        {
            if (request.CustomerAccountId.IsNullOrEmpty() ||
                request.CourseId.IsNullOrEmpty())
            {
                return new BaseResponseDTO<WishList>
                {
                    Success = false,
                    Message = "CustomerId and CourseId must be given."
                };
            }

            var customerAcc = await _unitOfWork.Accounts.GetById(request.CustomerAccountId);

            if (customerAcc == null)
            {
                return new BaseResponseDTO<WishList>
                {
                    Success = false,
                    Message = $"Unable to find customer with id {request.CustomerAccountId}."
                };
            }

            var course = await _unitOfWork.Courses.GetById(request.CourseId);

            if (course == null)
            {
                return new BaseResponseDTO<WishList>
                {
                    Success = false,
                    Message = $"Unable to find course with id {request.CourseId}."
                };
            }

            var existingWishlist = (await _unitOfWork.WishLists.GetAll())
                                            .FirstOrDefault(w => w.CustomerId == request.CustomerAccountId &&
                                                                 w.CourseId == request.CourseId);

            if (existingWishlist != null)
            {
                return new BaseResponseDTO<WishList>
                {
                    Success = false,
                    Message = $"The customer already has a wishlist for the course."
                };
            }

            var newWishList = new WishList
            {
                CustomerId = request.CustomerAccountId,
                CourseId = request.CourseId,
            };

            try
            {
                await _unitOfWork.WishLists.Add(newWishList);
                await _unitOfWork.SaveChanges();

                return new BaseResponseDTO<WishList> { Success = true, Object = newWishList };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<WishList>
                {
                    Success = false,
                    Message = $"There has been an error creating wishlist. Ex: {ex.Message}"
                };
            }
        }

        public async Task<BaseResponseDTO<WishList>> DeleteWishList(string id)
        {
            var wishlist = await _unitOfWork.WishLists.GetById(id);

            if (wishlist == null)
            {
                return new BaseResponseDTO<WishList>
                {
                    Success = false,
                    Message = $"Unable to find wishlist with id {id}."
                };
            }

            try
            {
                await _unitOfWork.WishLists.Delete(wishlist);
                await _unitOfWork.SaveChanges();

                return new BaseResponseDTO<WishList> { Success = true };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<WishList>
                {
                    Success = false,
                    Message = $"There has been an error deleting wishlist. Ex: {ex.Message}."
                };
            }
        }

        public async Task<BaseResponseDTO<GetWishlistResponse>> GetWishListByCourseId(string id)
        {
            var course = await _unitOfWork.Courses.GetById(id);

            if (course == null)
            {
                return new BaseResponseDTO<GetWishlistResponse>
                {
                    Success = false,
                    Message = $"Unable to find course with id {id}."
                };
            }

            var wishlists = (await _unitOfWork.WishLists.GetAllWishLists())
                                        .Where(w => w.CourseId == id)
                                        .ToList();

            if (!wishlists.Any())
            {
                return new BaseResponseDTO<GetWishlistResponse>
                {
                    Success = false,
                    Message = $"There are no wishlist for the course."
                };
            }

            var mappedResponse = _mapper.Map<List<GetWishlistResponse>>(wishlists);

            return new BaseResponseDTO<GetWishlistResponse> { Success = true, ObjectList = mappedResponse };
        }
    }
}
