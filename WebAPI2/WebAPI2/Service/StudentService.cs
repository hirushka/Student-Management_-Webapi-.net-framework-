using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI2.Models;
using WebAPI2.Reporsitory.Contract;
using WebAPI2.Service.Contract;

namespace WebAPI2.Service
{
    public class StudentService : IStudentSevice
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<bool> AddStudentAsync(Student std)
        {
            DateTime now = DateTime.Now;
            std.RegisteredDate = now;
            return await _studentRepository.CreateStudentAsync(std);
        }

        public async Task<ICollection<Student>> GetStudentAsync()
        {
            return await _studentRepository.GetStudentAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int Id)
        {
            return await _studentRepository.GetStudentByIDAsync(Id);
        }

        public async Task<bool> HardStudentAsync(Student std)
        {
            return await _studentRepository.HardDeleteStudentAsync(std);
        }

        public async Task<bool> UpdateStudentAsync(Student std)
        {
            return await _studentRepository.UpdateStudentAsync(std);
        }
    }
}
