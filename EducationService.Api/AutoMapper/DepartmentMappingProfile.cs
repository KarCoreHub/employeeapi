using AutoMapper;
using EducationService.Api.ApiModels;
using EducationService.Api.ApiModels.DepartmentModels;
using EducationService.Application.Dtos.DepartmentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationService.Api.AutoMapper
{
    public class DepartmentMappingProfile : Profile
    {
        public DepartmentMappingProfile()
        {
            CreateMap<CreateDepartmentModel, CreateDepartmentDto>();
            CreateMap<DepartmentDetailsDto, DepartmentDetailsModel>();
            CreateMap<UpdateDepartmentModel, UpdateDepartmentDto>();
        }
    }
}
