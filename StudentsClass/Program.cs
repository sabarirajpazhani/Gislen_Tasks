using System;
using System.Collections.Generic;

namespace StudentsClass
{
    public class Program
    {
        public static void AddStudents()
        {
            Dictionary<int,Students> student = new Dictionary<int,Students>();
            Console.Write("Enter the Number of Students: ");
            int num_stud = int.Parse(Console.ReadLine());

            int id = 100;
            for (int i = 0; i < num_stud; i++)
            {
                Students newStud = new Students();
                Console.Write("Students ID: ");
                newStud.SId = ++id;
                Console.WriteLine(newStud.SId);

                Console.Write("Ente the Student Name: ");
                newStud.Stud_Name = Console.ReadLine();

                Console.Write("Enter the Students Age: ");
                newStud.Age = int.Parse(Console.ReadLine());

                Console.Write("Enter the Student Mark: ");
                newStud.Mark = int.Parse(Console.ReadLine());

                student.Add(newStud.SId,newStud);
                Console.WriteLine("-----------------------------------------------------------");
            }

            foreach(KeyValuePair<int, Students> i in student)
            {
                Console.WriteLine(i.Key +" - "+i.Value.Stud_Name);
            }

            Console.WriteLine("Want to seach the name: y/n");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'y')
            {
                SeachingByName(student);
            }
            else
            {
                Console.WriteLine("Thank You..!");
            }
        }

        public static void SeachingByName(Dictionary<int,Students> student)
        {
            Console.WriteLine("Enter the Seach by Name : ");
            string str = Console.ReadLine();

            foreach(KeyValuePair<int,Students> i in student)
            {
                if(i.Value.Stud_Name == str)
                {
                    Console.WriteLine($"{i.Key} - {i.Value.Stud_Name} - {i.Value.Age} - {i.Value.Mark}");
                }
                else
                {
                    Console.WriteLine("Not Found :(");
                }
            }
        }
        static void Main(string[] args)
        {
            AddStudents();
            

        }
    }

    public class Students
    {
        public int SId { get; set; }
        public string Stud_Name { get; set; }
        public int Age { get; set; }
        public int Mark { get; set; }
    }
}