using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourseServices : ICourseServices
    {
        private readonly ICoursesRepository _CoursesRepository;
        public CourseServices(ICoursesRepository CoursesRepository)
        {
            this._CoursesRepository = CoursesRepository;
        }
        public async Task<IEnumerable<Models.Course>> GetCourses()
        {
            return await this._CoursesRepository.GetCourses();
        }
        public async Task<bool> AddCourse(string name)
        {
            Models.Course course = new Models.Course() { CourseName = name };
            var result = await this._CoursesRepository.AddCourse(course);
            return result;
        }

        public async Task<IEnumerable<Models.Course>> GetCourseByID(int id)
        {
            return await this._CoursesRepository.GetCourseById(id);
        }
        public async Task<IEnumerable<Models.Course>> GetCourseByName(string Name)
        {
            return await this._CoursesRepository.GetCourseByName(Name);
        }
        public async Task<IEnumerable<Student_CourseDTO>> GetStudentByCourse(string CourseName)
        {
            return await this._CoursesRepository.GetStudentByCourse(CourseName);
        }
        public async Task<bool> UpdateCourseName(string Name, int ID)
        {
            var courseid = await _CoursesRepository.GetCourseById(ID);
            await _CoursesRepository.UpdateCourseName(Name, ID);
            return true;
        }
    }
}