﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Repositories.Interface;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/equipmentCategories")]
    public class EquipmentCategoryController : ControllerBase
    {
        private readonly IEquipmentCategoryService _equipmentCategoryService;

        public EquipmentCategoryController(IEquipmentCategoryService equipmentCategoryService)
        {
            _equipmentCategoryService = equipmentCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEquipmentCategories()
        {
            var response = await _equipmentCategoryService.GetAllEquipmentCategories();

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEquipmentCategory(CreateEquipmentCategoryRequest request)
        {
            var response = await _equipmentCategoryService.CreateEquipmentCategory(request);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEquipmentCategory(UpdateEquipmentCategoryRequest request)
        {
            var response = await _equipmentCategoryService.UpdateEquipmentCategory(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEquipmentCategoryById(string id)
        {
            var response = await _equipmentCategoryService.GetEquipmentCategoryById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return NotFound(response.Message);
            }
        }

    }
}
