using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI2.Dtos
{
    public class DepartmentDTO
    {

        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }

    public class CreateDepartmentDTO
    {
        [Required]
        public string DepartmentName { get; set; }
    }
}
