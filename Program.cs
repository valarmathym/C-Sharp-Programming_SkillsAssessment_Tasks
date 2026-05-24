using System;
using System.Security.Cryptography.X509Certificates;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            string[] subjects = { "Math", "Science", "English" };
            string studentName = "Sue";


            //TODO: 6, instantiate student and add to people collection

            Student stu = new Student(studentName, subjects);
            people.Add(stu);
            
           


            string faculty = "Computer Science";
            string teacherName = "Tim";

            //TODO: 7, instantiate teacher and add to people collection

            Teacher teach = new Teacher(teacherName, faculty);
            people.Add(teach);

            
            //TODO: 8, iterate through people collection and invoke PrintDetails for each element
          
            foreach ( Person person in people)
            {
                person.PrintDetails();
            }
            
            Console.ReadKey();
        }
    }
}



