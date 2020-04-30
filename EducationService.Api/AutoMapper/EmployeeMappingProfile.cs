using AutoMapper;
using EducationService.Api.ApiModels.EmployeeModels;
using EducationService.Application.Dtos.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationService.Api.AutoMapper
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<CreateEmployeeModel, CreateEmployeeDto>();
            CreateMap<UpdateEmployeeModel, UpdateEmployeeDto>();
            CreateMap<EmployeeDetailsDto, EmployeeDetailsModel>();
        }
    }
}
