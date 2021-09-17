using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;

namespace WebAPI2.Reporsitory.Contract
{
    public interface IStudentRepository
    {
       
        Task<ICollection<Student>> GetStudentAsync();
        Task<Student> GetStudentByIDAsync(int id);
        Task<bool> CreateStudentAsync(Student std);
        Task<bool> UpdateStudentAsync(Student std);
        Task<bool> HardDeleteStudentAsync(Student std);
    }
}
