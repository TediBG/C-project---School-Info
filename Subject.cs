using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Info___Theodor_Popov
{
    internal class Subject
    {
        public string SubName { get; set; } //тук си създавам свойство за Име на Предмет
        public string TeacherTeachingTheSub { get; set; } //тук си създавам свойство за Учител по предмета
        //public double Grades { get; set; } //тук си създавам свойство за Оценки по предмета

        public void SubTeachInfo() // метод за въвеждане на данни относно предмета
        {
            Console.WriteLine("Insert subject's name:");
            SubName = Console.ReadLine();
            Console.WriteLine("Insert teacher's name:");
            TeacherTeachingTheSub = Console.ReadLine();

        }
        public static double avgGrades() // метод за смятане на средния успех
        {
            double grade = 4;
            double grade1 = 5.45;
            double grade2 = 4.25;
            double grade3 = 4.5;
            double grade4 = 6;
            double gradeAverage = 0;
            double gradeResult = 0;
            gradeAverage = grade + grade1 + grade2 + grade3 + grade4;
            gradeResult = gradeAverage / 5;
            return gradeResult;
        }

        double useAvgGrades = avgGrades();

        //List<double> listgrades = SubInfo();
        //foreach (double grade in listGrades)
        //{
        //    Console.WriteLine(grade);
        //}
        //       public static List<double> SubInfo()
        //{
        //    List<double> grades = new List<double>() { 5, 4, 4.50, 4.20, 6, 5 };
        //    double gradesListLength = grades.Count();
        //    double gradesSum = grades.Sum();
        //    double avgGrades = gradesSum / gradesListLength;
        //    return grades;
        //}

        //double[] grades = { 5, 4, 4.50, 4.20, 6, 5 };
        //double gradesListLength = grades.Count();
        //double gradesSum = grades.Sum();
        //double avgGrades = gradesSum / gradesListLength;

        public Subject(string subName, string teacherTeachingTheSub) //създавам си конструктор, за да си въвеждам данните за предмета
        {
            SubName = subName; //присвоявам стойност чрез аргументи
            TeacherTeachingTheSub = teacherTeachingTheSub; //присвоявам стойност чрез аргументи
            //Grades = grades;//присвоявам стойност чрез аргументи
        }
        public void SubInfo1() //създавам си метод, който ще използвам за обеките
        {
            Console.WriteLine($"The subject name is {SubName}, the teacher is {TeacherTeachingTheSub} and the grades are {useAvgGrades}.");
            //това тук е информацията предмета, която давам, чрез метода
        }
    }
}
