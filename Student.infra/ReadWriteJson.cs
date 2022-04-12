using Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Student.infra
{
   public class ReadWriteJson : IReadWrite
    {
        public List<Models.Student> Getstudent()
        {
            var json = File.ReadAllText(@"C:\Rami\student.txt");
            return JsonConvert.DeserializeObject<List<Models.Student>>(json);
        }

        public bool Writestudent(List<Models.Student> students)
        {
            File.WriteAllText(@"C:\Rami\student.txt", JsonConvert.SerializeObject(students, Formatting.Indented));
            return true;
        }

       
    }
}
