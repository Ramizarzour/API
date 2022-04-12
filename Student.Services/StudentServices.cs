using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Services;
using Models;
using System.Threading.Tasks;


namespace Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentsRepository _studentsRepository;
        public StudentServices(IStudentsRepository studentsRepository)
        {
            this._studentsRepository = studentsRepository;
        }
        public async Task<IEnumerable<Models.Student>> GetStudents()
        {
            return await this._studentsRepository.GetStudents();
        }
        public async Task<bool> AddStudent(string name)
        {
            Models.Student student = new Models.Student() { StudentName = name };
            var result = await this._studentsRepository.AddStudent(student);
            return result;
        }

        public async Task<IEnumerable<Models.Student>> GetStudentByID(int id)
        {
            return await this._studentsRepository.GetStudentById(id);
        }
        public async Task<IEnumerable<Models.Student>> GetStudentByName(string Name)
        {
            return await this._studentsRepository.GetStudentByName(Name);
        }
        public async Task<IEnumerable<Student_CourseDTO>> GetCourseByStudent( string StudentName)
        {
            return await this._studentsRepository.GetCourseByStudent(StudentName);
        }
        public async Task<bool> UpdateStudentName(string Name, int ID)
        {
            var StudentId = await _studentsRepository.GetStudentById(ID);
            await _studentsRepository.UpdateStudentName(Name, ID);
            return true;
        }
      


    }
}



