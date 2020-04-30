using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationService.Api.ApiModels
{
    public class CreateDepartmentModel
    {
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string DepartmentName { get; set; }

        [MaxLength(200)]
        [MinLength(20)]
        public string Description { get; set; }
    }
}
