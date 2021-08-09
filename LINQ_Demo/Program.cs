using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // make some test scores
            int[] scores = new[] { 50, 66, 90, 81, 77, 45, 0, 100, 99, 72, 87, 85, 81, 80, 77, 74, 95, 97 };

            foreach(int individualScores in scores)
            {
                Console.WriteLine("One of the scores was {0}", individualScores);
            }

            // Pause to see output before closing
            Console.ReadLine();

            // use a LINQ statement to filter the list
            var theBestStudents =
                from individualScore in scores
                where individualScore > 90
                select individualScore;

            foreach(var individualScores in theBestStudents)
            {
                Console.WriteLine("One of the BEST scores was {0}", individualScores);
            }
            // pause to see output before closing
            Console.ReadLine();

            var sortedScores =
                from individualScores in scores
                orderby individualScores
                select individualScores;

            foreach(var individualScore in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", individualScore);
            }
            // pause to see output before closing
            Console.ReadLine();

            var theBStudents_1 =
                from individualScores in scores
                where individualScores > 79 
                select individualScores;

            var theBstudents_2 =
                from individualScores in theBStudents_1
                where individualScores < 90
                select individualScores;

            foreach(var individualScore in theBstudents_2)
            {
                Console.WriteLine("One of the B students scores was {0}", individualScore);
            }

            // pause to see output before closing
            Console.ReadLine();

            List<Students> students = new List<Students>();

            students.Add(new Students("Zed", 24, 91));
            students.Add(new Students("David", 35, 100));
            students.Add(new Students("Chris", 34, 100));
            students.Add(new Students("Chris", 24, 85));
            students.Add(new Students("Adam", 21, 56));

            var sortedStudent =
                from student in students
                orderby student.name
                select student.toString();

            foreach(var student in sortedStudent)
            {
                Console.WriteLine("The students in the list are {0}", student);
            }

            // pause to see output before closing
            Console.ReadLine();

            students.Sort();

            foreach(var student in students)
            {
                Console.WriteLine(student.toString());
            }
            // pause to see output before closing
            Console.ReadLine();
        }
    }
}
