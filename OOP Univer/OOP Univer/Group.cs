using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Univer
{
    abstract class Group
    {
        public string GroupName { get; set; }

        public Student[] students; 

        public void ShowStudents()  //вывести список студентов
        {
            
            Console.WriteLine("Список студентов в группе");
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    Console.WriteLine("свободное место");
                }
                else
                {
                    Console.WriteLine(students[i].Surname + " " + students[i].Name);
                }
            }
            Delay();
        }

        public void AddStudent()    //добавить студента в группу
        {
            bool flag = false;
            for (int i = 0; i < students.Length; i++)   //ищем пустой элемент и добавляем студента, если есть пустой элемент
            {
                if (students[i] == null)
                {
                    Console.WriteLine("Введите имя студета:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Введите фамилию студета:");
                    string fam = Console.ReadLine();

                    students[i] = new Student(name, fam);
                    flag = true;
                    Test(i);

                    if (fam.Last() == 'а' || fam.Last() == 'я')
                    {
                        Console.WriteLine(students[i].Surname + " успешно добавлена в группу.");
                        Delay();
                    }
                    else
                    {
                        Console.WriteLine(students[i].Surname + " успешно добавлен в группу.");
                        Delay();
                    }
                    break;
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Группа полная, зачислить студента невозможно.");
                Delay();
            }
        }

        public void DeleteStudent() //удалить студента
        {
            Console.WriteLine("Введите фамилию студента на отчисление:");
            string famV = Console.ReadLine();
            string famN = famV;

            for (int i = 0; i < students.Length; i++)//ищем по фамилии и зануляем элемент, если находим
            {
                if (students[i] == null)
                {
                    continue;
                }

                else if (students[i].Surname == famV)
                {
                    students[i] = null;
                    famN = null;
                }               
            }

            if (famN == null)//вывод результата отчисления студента
            {
                Console.WriteLine("Студент " + famV + " отчислен.");
                Delay();
            }
            else
            {
                Console.WriteLine(famV + " не найден в группе.");
                Delay();
            }
        }

        public virtual void Test(int i)
        {
            Console.WriteLine("Студент {0} сдал вступительный экзамен.", students[i].Surname);
            Delay();
        }


        public void Delay()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
