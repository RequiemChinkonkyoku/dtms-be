using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICategoryService
    {
        Task<BaseResponseDTO<Category>> CreateCategory(CreateCategoryRequest request);
        Task<BaseResponseDTO<Category>> DeleteCategory(string id);
        Task<BaseResponseDTO<Category>> GetAllCategories();
        Task<BaseResponseDTO<Category>> GetCategoryById(string id);
        Task<BaseResponseDTO<Category>> UpdateCategory(UpdateCategoryRequest request);
    }
}
