using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface  ICourseServices
    {
        public Task<IEnumerable<Models.Course>> GetCourses();
        public Task<bool> AddCourse(string Name);

        public Task<IEnumerable<Models.Course>> GetCourseByID(int id);

        public Task<IEnumerable<Models.Course>> GetCourseByName(string Name);

        public Task<IEnumerable<Student_CourseDTO>> GetStudentByCourse(string CourseName);
        public Task<bool> UpdateCourseName(string Name, int ID);

    }
}
