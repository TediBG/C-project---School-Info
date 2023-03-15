using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Info___Theodor_Popov
{
    internal class Teachers
    {
        public string TeachFirstName { get; set; } //тук си създавам свойство за Име на Учител
        public string TeachSurname { get; set; } //тук си създавам свойство за Фамилия на Учител
        public string TeachingSubject { get; set; } //тук си създавам свойство за Предмет, по който преподава
        public string TeachingClasses { get; set; } //тук си създавам свойство за Класът на който ще се предподава

        public void TeachInfo() // метод за въвеждане на данни на учител
        {
            Console.WriteLine("Insert teacher's first name:");
            TeachFirstName = Console.ReadLine();
            Console.WriteLine("Insert teacher's the surname");
            TeachSurname = Console.ReadLine();
            Console.WriteLine("Insert the subject teached by the teacher name");
            TeachingSubject = Console.ReadLine();
            Console.WriteLine("Insert the class the teacher is teaching");
            TeachingClasses = Console.ReadLine();
            {
                //for (int i = 0; i <= 4; i++)
                //{
                //TeachingClasses = Console.ReadLine();
                //    string listClasses = i.ToString();
                //    List<string> classes = new List<string>();
                //    classes.Add(listClasses);
                //    listClasses = UseClasses;
        //public string UseClasses { get; set; }
                //}
            }
        }

        public Teachers(string teachFirstName, string teachSurname, string teachingSubject, string teachingclasses) //създавам си конструктор, за да си въвеждам данните за учителя
        {
            TeachFirstName = teachFirstName; //присвоявам стойност чрез аргументи
            TeachSurname = teachSurname; //присвоявам стойност чрез аргументи
            TeachingSubject = teachingSubject; //присвоявам стойност чрез аргументи
            TeachingClasses = teachingclasses; //присвоявам стойност чрез аргументи
        }
        public void TeachInfo1() //създавам си метод, който ще използвам за обеките
        {
            Console.WriteLine($"The teacher's name and surname are {TeachFirstName} {TeachSurname}, the subject he teaches is {TeachingSubject} and the class he/she is teaching are {TeachingClasses}.");
            //това тук е информацията учителите, която давам, чрез метода
        }
    }
}
