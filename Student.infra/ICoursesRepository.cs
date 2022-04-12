using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Infrastructure
{
    public interface ICoursesRepository
    {

      
        public Task<IEnumerable<Models.Course>> GetCourses();
        public Task<bool> AddCourse(Models.Course course);

        public Task<IEnumerable<Models.Course>> GetCourseById(int id);
        public Task<IEnumerable<Models.Course>> GetCourseByName(string name);
        public Task<IEnumerable<Infrastructure.Student_CourseDTO>> GetStudentByCourse(string CourseName);
        public Task<bool> UpdateCourseName(string Name, int ID);
    }
}
