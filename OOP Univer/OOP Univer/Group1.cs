﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Univer
{
    class Group1: Group
    {
        public Group1(string name, int n)
        {
            this.GroupName = name;
            this.students = new Student[n];
            Console.WriteLine(this.GroupName + " создана.");
        }
        
        public override void Test(int i)
        {
            Console.WriteLine("Студент {0} сдал устный экзамен.", students[i].Surname);
        }
    }
}
