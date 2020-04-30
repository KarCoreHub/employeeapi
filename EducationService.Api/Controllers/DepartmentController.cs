﻿using AutoMapper;
using EducationService.Api.ApiModels;
using EducationService.Api.ApiModels.DepartmentModels;
using EducationService.Api.AutoMapper;
using EducationService.Application.Dtos.DepartmentDtos;
using EducationService.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationService.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<DepartmentDetailsModel>> GetDepartmentList()
        {
            List<DepartmentDetailsDto> departmentDetailsDtos = await _departmentService.GetDepartmentListAsync();
            List<DepartmentDetailsModel> departmentList = _mapper.Map<List<DepartmentDetailsModel>>(departmentDetailsDtos);
            return departmentList;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment([FromBody] CreateDepartmentModel createDepartmentModel)
        {
            CreateDepartmentDto createDepartmentDto = _mapper.Map<CreateDepartmentDto>(createDepartmentModel);
            await _departmentService.CreateDepartmentAsync(createDepartmentDto);
            return Ok();
        }

        [HttpGet]
        public async Task<SelectList> GetDepartmentSelectList(int? selectedDepartment)
        {
            SelectList selectList = await _departmentService.GetDepartmentSelectListAsync(selectedDepartment);
            return selectList;
        }

        [HttpGet("{departmentId}")]
        public async Task<DepartmentDetailsModel> GetDepartment(int departmentId)
        {
            DepartmentDetailsDto departmentDetailsDto = await _departmentService.GetDepartmentAsync(departmentId);
            DepartmentDetailsModel departmentDetailsModel = _mapper.Map<DepartmentDetailsModel>(departmentDetailsDto);
            return departmentDetailsModel;
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDepartment([FromBody] UpdateDepartmentModel updateDepartmentModel)
        {
            UpdateDepartmentDto updateDepartmentDto = _mapper.Map<UpdateDepartmentDto>(updateDepartmentModel);
            await _departmentService.UpdateDepartmentAsync(updateDepartmentDto);
            return Ok();
        }

        [HttpDelete("{departmentId}")]
        public async Task<IActionResult> DeleteDepartment(int departmentId)
        {
            await _departmentService.DeleteDepartment(departmentId);
            return Ok();
        }
    }
}