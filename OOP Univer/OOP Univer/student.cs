using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Univer
{
    class Student
    {       
        public string Name
        { get; set; }

        public string Surname
        { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            this.Surname = surname;
        }
    }
}
