using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Info___Theodor_Popov
{
    public class StudentsInSchool
    {
        public string StudFirstName { get; set; } //тук си създавам свойство за Име на Ученик
        public string StudSurname { get; set; } //тук си създавам свойство за Фамилия на Ученик
        public string StudInSchoolClass { get; set; } //тук си създавам свойство за Класът в дадено училище
    
        public void StudInfo() // метод за въвеждане на данни на учeник
        {
            Console.WriteLine("Insert student's first name:");
            StudFirstName = Console.ReadLine();
            Console.WriteLine("Insert the student's surname:");
            StudSurname = Console.ReadLine();
            Console.WriteLine("Insert in which class is the student:");
            StudInSchoolClass = Console.ReadLine();
            {
                //Console.WriteLine("Insert the student's surname:");
                //StudSurname = Console.ReadLine();
                //Console.WriteLine("Insert the first name of the second student:");
                //StudFirstName = Console.ReadLine();
                //Console.WriteLine("Insert the student's surname:");
                //StudSurname = Console.ReadLine();
                //Console.WriteLine("Insert the first name of the third student:");
                //StudFirstName = Console.ReadLine();
                //Console.WriteLine("Insert the student's surname:");
                //StudSurname = Console.ReadLine();
                //Console.WriteLine("Insert the first name of the fourth student:");
                //StudFirstName = Console.ReadLine();
                //Console.WriteLine("Insert the student's surname:");
                //StudSurname = Console.ReadLine();
                //Console.WriteLine("Insert the first name of the fifth student:");
                //StudFirstName = Console.ReadLine();
                //    Console.WriteLine("Insert in which class is the second student:");
                //    StudInSchoolClass = Console.ReadLine();
                //    Console.WriteLine("Insert in which class is the third student:");
                //    StudInSchoolClass = Console.ReadLine();
                //    Console.WriteLine("Insert in which class is the fourth student:");
                //    StudInSchoolClass = Console.ReadLine();
                //    Console.WriteLine("Insert in which class is the fifth student:");
                //    StudInSchoolClass = Console.ReadLine();
                }
            }
        public StudentsInSchool(string studFirstName, string studSurname, string studInSchoolClass) //създавам си конструктор, за да си въвеждам данните за ученика
        {
            StudFirstName = studFirstName; //присвоявам стойност чрез аргументи
            StudSurname = studSurname; //присвоявам стойност чрез аргументи
            StudInSchoolClass = studInSchoolClass; //присвоявам стойност чрез аргументи
        }
        public void StudInfo1() //създавам си метод, който ще използвам за обеките
        {
            Console.WriteLine($"The student's name and surname are {StudFirstName} {StudSurname} and he/she is in {StudInSchoolClass} class.");
            //това тук е информацията за учениците, която давам, чрез метода
        }
    }
}
