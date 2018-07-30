using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Univer
{
    class Group2: Group
    {
        public Group2(string name, int n)
        {
            this.GroupName = name;
            this.students = new Student[n];
            Console.WriteLine(this.GroupName + " создана.");
        }

        public override void Test(int i)
        {
            Console.WriteLine("Студент {0} сдал письменный экзамен.", students[i].Surname);
        }
    }
}
