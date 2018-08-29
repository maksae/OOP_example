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

        public override void Test(int i)    //студенты второй группы проходят тестирование
        {
            Console.WriteLine("Студент {0} успешно прошел тестирование.", students[i].Surname);
        }
    }
}
