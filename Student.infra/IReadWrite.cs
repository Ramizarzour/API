using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Infrastructure
{public interface IReadWrite
    {
        public bool Writestudent(List<Models.Student> students);
        public List<Models.Student> Getstudent();

    }
}

