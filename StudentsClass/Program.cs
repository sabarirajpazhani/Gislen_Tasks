using System;
using System.Collections.Generic;

namespace StudentsClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Students> student = new List<Students>();
            Console.Write("Enter the Number of Students: ");
            int num_stud = int.Parse(Console.ReadLine());

            int id = 100;
            for(int i=0;i<num_stud;i++)
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

                student.Add(newStud);
                Console.WriteLine("-----------------------------------------------------------");
            }

            student.ForEach(x => Console.WriteLine(x.Stud_Name));
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