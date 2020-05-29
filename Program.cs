using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        public class Student
        {
            public string id;
            public string fio;
            public string group;
            public string birthDate;
        }

        static List<Student> studentList = new List<Student>();

        static void DobStudenta(string id, string fio, string group, string birthDate)
        {
            studentList.Add(new Student() { id = id, fio = fio, birthDate = birthDate, group = group });
        }


        static void YdStudenta(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id) studentList.RemoveAt(i);
            }
        }

        static void IzmStudenta(string id, string fio, string birthDate, string group)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    studentList[i].fio = fio;
                    studentList[i].group = group;
                    studentList[i].birthDate = birthDate;
                }
            }

        }

        static void ShowStudent()
        {

            foreach (var f in studentList)
            {
                Console.WriteLine(f.id + " - " + f.fio + " - " + f.birthDate  + " - " + f.group);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student first = new Student();

            DobStudenta("984", "Михно Иван Всеволодович", "24.05.1895", "TEMY");
            DobStudenta("1777", "Собчак Мартын Никитевич", "12.01.1890", "ANDR");
            DobStudenta("465", "Куроптев Агафон Адрианович", "29.12.1920", "LIKR");
            ShowStudent();
            IzmStudenta("1777", "Осипов Семён Иннокентиевич", "19.08.1925", "ANDR");
            ShowStudent();
            YdStudenta("465");
            ShowStudent();
        }
    }
}

