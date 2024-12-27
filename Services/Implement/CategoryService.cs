using Microsoft.IdentityModel.Tokens;
using Models.DTOs;
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
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO<Category>> GetAllCategories()
        {
            var response = await _unitOfWork.Categories.GetAll();

            return new BaseResponseDTO<Category> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<Category>> CreateCategory(CreateCategoryRequest request)
        {
            var category = new Category()
            {
                Name = request.Name,
                Description = request.Description,
                Status = 1,
                CreatedTime = DateTime.Now,
                LastUpdatedTime = DateTime.Now,
            };

            await _unitOfWork.Categories.Add(category);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Category> { Success = true, Object = category };
        }

        public async Task<BaseResponseDTO<Category>> UpdateCategory(UpdateCategoryRequest request)
        {
            if (request.Id.IsNullOrEmpty())
            {
                return new BaseResponseDTO<Category> { Success = false, Message = "Id must be given." };
            }

            var category = await _unitOfWork.Categories.GetById(request.Id);

            if (category == null)
            {
                return new BaseResponseDTO<Category> { Success = false, Message = "Unable to find category with id " + request.Id };
            }

            category.Name = request.Name;
            category.Description = request.Description;
            category.Status = request.Status;
            category.LastUpdatedTime = DateTime.Now;

            await _unitOfWork.Categories.Update(category);
            await _unitOfWork.SaveChanges();

            return new BaseResponseDTO<Category> { Success = true, Object = category };
        }
    }
}
