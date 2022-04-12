using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Infrastructure
{
    public interface IStudentsRepository
    {
        public Task<IEnumerable<Models.Student>> GetStudents();
        public Task<bool> AddStudent(Models.Student student);
        public Task<IEnumerable<Models.Student>> GetStudentById(int id);
        public Task<IEnumerable<Models.Student>> GetStudentByName(string Name);
        public Task<IEnumerable<Infrastructure.Student_CourseDTO>> GetCourseByStudent(string StudentName);
        public Task<bool> UpdateStudentName(string Name, int ID);




    }
}
