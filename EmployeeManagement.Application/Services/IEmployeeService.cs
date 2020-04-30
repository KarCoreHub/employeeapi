using AspNetCore.ServiceRegistration.Dynamic.Interfaces;
using EducationService.Application.Dtos.EmployeeDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationService.Application.Services
{
    public interface IEmployeeService : IScopedService
    {
        Task<List<EmployeeDetailsDto>> GetEmployeeListAsync();

        Task<EmployeeDetailsDto> GetEmployeeDetailsAsync(int employeeId);

        Task CreateEmployeeAsync(CreateEmployeeDto createEmployeeDto);

        Task UpdateEmplyeeAsync(UpdateEmployeeDto updateEmployeeDto);

        Task DeleteEmployee(int employeeId);
    }
}
