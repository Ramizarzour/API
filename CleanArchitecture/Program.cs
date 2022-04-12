//using Newtonsoft.Json;
//using Student;
//using Services;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using Infrastructure;
//using Student.infra;

//namespace CleanArchitecture
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("1 for json , 2 for text");
//            var enteredFileType = Console.ReadLine();
//            IReadWrite readwrite;
//            if (enteredFileType == "1")
//            {
//                readwrite = new ReadWriteJson();
//            }
//            else
//            {
//                readwrite = new ReadWritetxt();
//            }

//            var service = new StudentServices(readwrite);

//            while (true)
//            {


//                Console.WriteLine("Choose an option from the following list:");
//                Console.WriteLine("\t 1 - Add a Student");
//                Console.WriteLine("\t 2- Search for a student by name ");
//                Console.WriteLine("\t 3 - Search for a student by course");
//                Console.WriteLine("\t 4 - Search for a student by Id ");
//                Console.WriteLine("\t 5 - Update a Student");
//                Console.WriteLine("\t 6 - Exit");
//                switch (Console.ReadLine())
//                {
//                    case "1":

//                        Console.WriteLine("Enter Id:");
//                        var enteredId = Console.ReadLine();
//                        var id = 0;
//                        int.TryParse(enteredId, out id);
//                        Console.WriteLine("Enter name:");
//                        var StudentName = Console.ReadLine();
//                        Console.WriteLine("Enter course name:");
//                        var CourseName = Console.ReadLine();

//                        service.AddStudent(id, StudentName, CourseName);

//                        break;


//                    case "2":
//                        Console.WriteLine("Search Student Name: ");

//                        var SearchStudentName = Console.ReadLine();
//                        var searchname = service.SearchName(SearchStudentName);

//                        searchname.ToList().ForEach(student =>
//                        {
//                            Console.WriteLine(student);
//                        });


//                        break;


//                    case "3":
//                        Console.WriteLine("Search Student by course: ");
//                        var searchstudentcourse = Console.ReadLine();

//                        var Searchcourse = service.SearchCourse(searchstudentcourse);


//                        Searchcourse.ToList().ForEach(student =>
//                        {
//                            Console.WriteLine(student);
//                            Console.WriteLine();


//                        });
//                        break;

//                    case "4":
//                        Console.WriteLine("Search Student by name: ");
//                        var Searchstudentid = Int32.Parse(Console.ReadLine());

//                        var searchid = service.SearchId(Searchstudentid);


//                        searchid.ToList().ForEach(student =>
//                        {
//                            Console.WriteLine(student);
//                            Console.WriteLine();


//                        });
//                        break;
                    
//                        if (File.Exists(@"C:\Rami\student.txt"))
//                        {
//                            Console.WriteLine("what you want to update existing students ?\n" +
//                                                "1- choose 1 name \n" +
//                                                "2- choose 2 for course \n");
                           
//                            switch (Console.ReadLine())
//                            {

//                                case "1":
//                                    Console.WriteLine(" Enter Old Name : ");
//                                    var Name = Console.ReadLine();

//                                    List<Models.Student> Getstudent()
//                                    {
//                                        var json = File.ReadAllText(@"C:\Rami\student.txt");
//                                        return JsonConvert.DeserializeObject<List<Models.Student>>(json);
//                                    }


//                                    List<Models.Student> Name2 = Name.Where(x => x.Name== Name2).ToList();
//                                    foreach (var NewName in Name2)
//                                    {
//                                        Console.WriteLine(" New name: ");
//                                        NewName.Name = (Console.ReadLine());
//                                        File.WriteAllText(@"C:\Rami\student.txt", JsonConvert.SerializeObject(student, Formatting.Indented));
//                                    }
//                                    break;
//                                case "2":
//                                    Console.WriteLine("Enter Old Course: ");
//                                    var Courses = Console.ReadLine();



//                                    List<Models.Student> coursess = Models.Student.Where(x => x.course == course1).ToList();
//                                    foreach (var course2 in coursess)
//                                    {
//                                        Console.WriteLine("Second name: ");
//                                        course2.course = (Console.ReadLine());
//                                        File.WriteAllText(@"C:\Rami\student.txt", JsonConvert.SerializeObject(students, Formatting.Indented));
//                                    }
//                                    break;







//                                    break;
//                            }
//                        }
//                } } } } }
