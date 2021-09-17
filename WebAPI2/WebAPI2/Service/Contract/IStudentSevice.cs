using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;

namespace WebAPI2.Service.Contract
{
    public interface IStudentSevice
    {
        
        Task<ICollection<Student>> GetStudentAsync();
        Task<Student> GetStudentByIdAsync(int Id);
        Task<bool> AddStudentAsync(Student std);
        Task<bool> UpdateStudentAsync(Student std);
        Task<bool> HardStudentAsync(Student std);



    }
}
