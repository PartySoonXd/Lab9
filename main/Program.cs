using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() 
            {
                new Student() { Name = "Игорь", SamplesCount = 10, TestScore = 85 },
                new Student() { Name = "Генадий", SamplesCount = 12, TestScore = 60},
                new Student() { Name = "Алина", SamplesCount = 2, TestScore = 80 },
            };
            List<Planet> planets = new List<Planet>()
            {
                new Mars(),
                new Venus(),
                new Mercury(),
                new Jupiter(),
            };

            foreach (Planet planet in planets)
            {
                Console.WriteLine($"\n{planet.Name}");
                Console.WriteLine("==========");
                foreach (Student student in students)
                {
                    if (planet is IHaveAngryResidents)
                    {
                        Console.WriteLine(planet.Check(student));
                        break;
                    }
                    Console.WriteLine($"{student.Name}: {planet.Check(student)}");
                }
            }
        }
    }
}
