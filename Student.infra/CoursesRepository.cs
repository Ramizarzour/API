using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly DapperContext _Infrastructure;
        public CoursesRepository(DapperContext Infrastructure)
        {
            _Infrastructure = Infrastructure;
        }
        public async Task<IEnumerable<Models.Course>> GetCourses()
        {
            var query = "SELECT * FROM Course";
            using (var connection = _Infrastructure.CreateConnection())
            {
                var Courses = await connection.QueryAsync<Models.Course>(query);
                return Courses.ToList();
            }
        }

        public async Task<bool> AddCourse(Models.Course course)
        {
            var query = "INSERT INTO Course (CourseName) VALUES (@Name)";
            var parametres = new DynamicParameters();
            parametres.Add("Name", course.CourseName, DbType.String);
            using (var connection = _Infrastructure.CreateConnection())
            {
                await connection.QueryAsync<Models.Course>(query, parametres);
                return true;
            }
        }
           public async Task<IEnumerable<Models.Course>> GetCourseById(int id)
            {
                var query = "SELECT * FROM Course WHERE CourseID = @ID";
                var parametres = new DynamicParameters();
                parametres.Add("ID", id, DbType.String);
                using (var connection = _Infrastructure.CreateConnection())
                {
                    var Courses = await connection.QueryAsync<Models.Course>(query, parametres);
                    return Courses;
                }
            }

        public async Task<IEnumerable<Models.Course>> GetCourseByName(string Name)
        {
            var query = "SELECT * FROM Course WHERE CourseName = @Name";
            var parametres = new DynamicParameters();
            parametres.Add("Name", Name, DbType.String);
            using (var connection = _Infrastructure.CreateConnection())
            {
                var Courses = await connection.QueryAsync<Models.Course>(query, parametres);
                return Courses;
            }
        }
        public async Task<IEnumerable<Infrastructure.Student_CourseDTO>> GetStudentByCourse(string CourseName)
        {
            var query = "Select C.CourseID, C.CourseName, S.StudentID, S.StudentName " +
                "FROM Register R " +
                "INNER JOIN Student S ON S.StudentID = R.StudentID " +
                "INNER JOIN Course C ON C.CourseID = R.CourseID " +
                "WHERE C.CourseName = @Course";
            var parametres = new DynamicParameters();
            parametres.Add("Course", CourseName, DbType.String);
            using (var connection = _Infrastructure.CreateConnection())
            {
                var students = await connection.QueryAsync<Infrastructure.Student_CourseDTO>(query, parametres);
                return students;
            }
        }
        public async Task<bool> UpdateCourseName(string Name, int ID)
        {
            var query = " UPDATE Course SET CourseName =@Name WHERE CourseID =@ID";
            var parameters = new DynamicParameters();
            parameters.Add("Name", Name, DbType.String);
            parameters.Add("ID", ID, DbType.Int32);
            using (var connection = _Infrastructure.CreateConnection())
            {
                var students = await connection.QueryAsync<Student_CourseDTO>(query, parameters);



                return true;
            }
            return false;
        }
    }
    }

