using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    
  
        public interface IStudentServices
        {
        public Task<IEnumerable<Models.Student>> GetStudents();
        public Task<bool> AddStudent(string Name);

        public Task<IEnumerable<Models.Student>> GetStudentByID(int id);
        public Task<IEnumerable<Models.Student>> GetStudentByName(string Name);
       
        public Task<IEnumerable<Student_CourseDTO>> GetCourseByStudent(string StudentName);
        public Task<bool> UpdateStudentName(string Name, int ID);




    }
}

