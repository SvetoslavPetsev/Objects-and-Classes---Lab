using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Students
{
    public class Students 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FromTown { get; set; }

    }
    class Program
    {
        static void Main()
        {
            List<Students> ListOfStudentsInfo = new List<Students>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string town = input[3];

                Students studentInfo = new Students();

                studentInfo.FirstName = firstName;
                studentInfo.LastName = lastName;
                studentInfo.Age = age;
                studentInfo.FromTown = town;

                ListOfStudentsInfo.Add(studentInfo);
            }

            string forTownSearch = Console.ReadLine();

            List<Students> filtered = ListOfStudentsInfo.Where(x => x.FromTown == forTownSearch).ToList();

            foreach ( var student in filtered)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
