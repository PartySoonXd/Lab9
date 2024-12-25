using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Mars : Planet, IRequireSamples, IRequireSurvivalTest 
    {
        public int SamplesCount { get; set; } = 5;
        public int TestScore { get; set; } = 80;
        public Mars() : base("Марс") { }
        public override string Check(Student student)
        {
            if (student.SamplesCount >= SamplesCount && student.TestScore >= TestScore)
            {
                return "Готов(а) к миссии!";
            }
            else if (student.SamplesCount >= SamplesCount && student.TestScore < TestScore) 
            {
                return "Не пройден тест на выживание";
            }
            else if (student.SamplesCount < SamplesCount && student.TestScore >= TestScore)
            {
                return "Не собрал(а) достаточное количество образцов";
            }
            return "Не готов(а) к миссии";
        }
    }
}
