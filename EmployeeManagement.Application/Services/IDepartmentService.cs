using AspNetCore.ServiceRegistration.Dynamic.Interfaces;
using EducationService.Application.Dtos.DepartmentDtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationService.Application.Services
{
    public interface IDepartmentService : IScopedService
    {
        Task<List<DepartmentDetailsDto>> GetDepartmentListAsync();

        Task CreateDepartmentAsync(CreateDepartmentDto createDepartmentDto);

        Task<SelectList> GetDepartmentSelectListAsync(int? selectedDepartmentId);

        Task<DepartmentDetailsDto> GetDepartmentAsync(int departmentId);

        Task UpdateDepartmentAsync(UpdateDepartmentDto updateDepartmentDto);

        Task DeleteDepartment(int employeeId);
    }
}
