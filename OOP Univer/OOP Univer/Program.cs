using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Univer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UNIVER");

            Group1 group1 = new Group1("Группа 1", 5);
            Group2 group2 = new Group2("Группа 2", 6);

            //создаем массив групп
            Group[] group = new Group[]
            {
                group1,
                group2,
             };


            //интерфейс работы с программой
            while (true)
            {
                int n = 0;
                Console.WriteLine(new string('_', 50));
                Console.WriteLine("Введите номер группы (от 1 до {0}):", group.Length);
                //проверяем введеное значение на число и попадение в диапазон элементов массива групп
                do
                {
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out n))
                    {
                        n -= 1;
                        if (n < 0 || n >= group.Length)
                        {
                            Console.WriteLine("Вы ввели неверный номер группы. Введите целое число от 1 до {0}", group.Length);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверный номер группы.Введите целое число от 1 до {0}", group.Length);
                        n = group.Length + 1;
                    }
                }
                while (n<0 || n>=group.Length);

                //если введено корректное значение, то переходим к управлению выбранной группой
                for (; ; )
                {
                    Console.WriteLine(new string('_', 50));

                    Console.WriteLine("Команды управления группой студентов - {0}: 1 - список студентов;" +
                    " 2 - добавить студента в группу; 3 - отчислить стуента; 4 - выйти из управления группой", group[n].GroupName);
                    Console.WriteLine("Введите команду:");

                    string command = null;
                    command = Console.ReadLine();

                    switch (command)
                    {
                        case "1":
                            {
                                group[n].ShowStudents();
                                continue;
                            }

                        case "2":
                            {
                                group[n].AddStudent();
                                continue;
                            }

                        case "3":
                            {
                                group[n].DeleteStudent();
                                continue;
                            }

                        case "4":
                            {
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("такой команды не существует.");
                                continue;
                            }

                    }
                    break;

                }

 
            }
        }
 
    }
}
