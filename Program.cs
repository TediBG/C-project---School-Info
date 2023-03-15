using System;
using System.IO;

namespace School_Info___Theodor_Popov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                /*
                StudentsInSchool s1 = new StudentsInSchool("Pesho", "Petrov","8e"); //обект от класа StudentsInSchool
                StudentsInSchool s2 = new StudentsInSchool("Gabriel", "Iordanov","9j"); //обект от класа StudentsInSchool
                StudentsInSchool s3 = new StudentsInSchool("Theodor", "Popov","10a"); //обект от класа StudentsInSchool
                StudentsInSchool s4 = new StudentsInSchool("Ivet", "Dinova","11v"); //обект от класа StudentsInSchool
                StudentsInSchool s5 = new StudentsInSchool("Vasil", "Levski","12b"); //обект от класа StudentsInSchool
                Subject sub1 = new Subject("OOP", "Violina Stoyanova", 6); //обект от класа Subject
                Subject sub2 = new Subject("Biology", "Petar Rachev", 5); //обект от класа Subject
                Subject sub3 = new Subject("CP", "Daniel Denev", 5); //обект от класа Subject
                Subject sub4 = new Subject("Chemistry", "Petar Rachev", 3); //обект от класа Subject
                Subject sub5 = new Subject("History", "Ivan Topuzanov", 4); //обект от класа Subject
                */
            }

            string name = null;
            string secondName = null;
            string studentsAndClasses = null;
            string subject = null;
            string teachersAndClasses = null; // това са променливи, чрез които ще си присвоя стойността, която съм въвел в конзолата
            StudentsInSchool stud1 = new StudentsInSchool(name, secondName, studentsAndClasses);
            stud1.StudFirstName = name;
            stud1.StudSurname = secondName;
            stud1.StudInSchoolClass = studentsAndClasses;
            stud1.StudInfo();
            stud1.StudInfo1();

            Teachers t1 = new Teachers(name, secondName, subject, teachersAndClasses);
            t1.TeachFirstName = name;
            t1.TeachSurname = secondName;
            t1.TeachingSubject = subject;
            t1.TeachingClasses = teachersAndClasses;
            t1.TeachInfo();
            t1.TeachInfo1();

            Subject sub1 = new Subject(name, secondName);
            sub1.SubName = name;
            sub1.TeacherTeachingTheSub = secondName;
            sub1.SubTeachInfo();
            sub1.SubInfo1();

            if (stud1.StudFirstName != stud1.StudSurname && t1.TeachFirstName != t1.TeachSurname) // проверка дали съвпадат името и фамилията на ученик и учител
            {

            try
            {
                using (StreamWriter sw = new StreamWriter(@"SchoolInfo.txt")) // изписваме във файл, чрез поток
                {
                    sw.Write("The Teacher who is teaching this subject: ");
                    sw.WriteLine(sub1.TeacherTeachingTheSub);
                    sw.Write("The Subject: ");
                    sw.WriteLine(sub1.SubName);
                    sw.Write("Student's first name: ");
                    sw.WriteLine(stud1.StudFirstName);
                    sw.Write("Student's Surname: ");
                    sw.WriteLine(stud1.StudSurname);
                    sw.Write("This student is in: ");
                    sw.WriteLine(stud1.StudInSchoolClass);
                    sw.Write("Teacher's Name: ");
                    sw.WriteLine(t1.TeachFirstName);
                    sw.Write("Teacher's Surname: ");
                    sw.WriteLine(t1.TeachSurname);
                    sw.Write("This teacher is teaching: ");
                    sw.WriteLine(t1.TeachingSubject);
                    sw.Write("The class this teacher is teaching: ");
                    sw.WriteLine(t1.TeachingClasses);
                }

            }
            catch (OutOfMemoryException exp)
            {

                Console.Write(exp.Message); // това е exception, ако паметта ни свърши
            }
            }
            else if (stud1.StudFirstName == stud1.StudSurname) // ако съвпадат ще даде следната "Грешка" и програмата ще спре
            {
                Console.WriteLine("Error! Student's names are the same!");
            }
            else if (t1.TeachFirstName == t1.TeachSurname) // ако съвпадат ще даде следната "Грешка" и програмата ще спре
            {
                Console.WriteLine("Error! Teacher's names are the same!");
            }
        }
    }
}
