using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly DapperContext _Infrastructure;
        public StudentsRepository(DapperContext Infrastructure)
        {
            _Infrastructure = Infrastructure;
        }


        public async Task<IEnumerable<Models.Student>> GetStudents()
        {
            var query = "SELECT * FROM Student";
            using (var connection = _Infrastructure.CreateConnection())
            {
                var Students = await connection.QueryAsync<Models.Student>(query);
                return Students.ToList();
            }
        }

        public async Task<bool> AddStudent(Models.Student student)
        {
            var query = "INSERT INTO Student (StudentName) VALUES (@Name)";
            var parametres = new DynamicParameters();
            parametres.Add("Name", student.StudentName, DbType.String);
            using (var connection = _Infrastructure.CreateConnection())
            {
                await connection.QueryAsync<Models.Student>(query, parametres);
                return true;
            }
        }
        public async Task<IEnumerable<Models.Student>> GetStudentById(int id)
        {
            var query = "SELECT * FROM Student WHERE STUDENTID = @ID";
            var parametres = new DynamicParameters();
            parametres.Add("ID", id, DbType.String);
            using (var connection = _Infrastructure.CreateConnection())
            {
                var students = await connection.QueryAsync<Models.Student>(query, parametres);
                return students;
            }
        }
        public async Task<IEnumerable<Models.Student>> GetStudentByName(string Name)
        {
            var query = "SELECT * FROM Student WHERE STUDENTName = @Name";
            var parametres = new DynamicParameters();
            parametres.Add("Name", Name, DbType.String);
            using (var connection = _Infrastructure.CreateConnection())
            {
                var students = await connection.QueryAsync<Models.Student>(query, parametres);
                return students;
            }
        }
        public async Task<IEnumerable<Infrastructure.Student_CourseDTO>> GetCourseByStudent(string StudentName)
        {
            var query = "Select C.CourseID, C.CourseName, S.StudentID, S.StudentName " +
                "FROM Register R " +
                "INNER JOIN Student S ON S.StudentID = R.StudentID " +
                "INNER JOIN Course C ON C.CourseID = R.CourseID " +
                "WHERE S.StudentName = @StudentName";
            var parametres = new DynamicParameters();
            parametres.Add("Student", StudentName, DbType.String);
            using (var connection = _Infrastructure.CreateConnection())
            {
                var Courses= await connection.QueryAsync<Infrastructure.Student_CourseDTO>(query, parametres);
                return Courses;
            }
        }
        public async Task<bool> UpdateStudentName(string Name, int ID)
        {   var query = " UPDATE Student SET StudentName =@Name WHERE StudentID =@ID";
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

