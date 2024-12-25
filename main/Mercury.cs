using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Mercury : Planet, IRequireSurvivalTest
    {
        public int TestScore { get; set; } = 60;
        public Mercury() : base("Меркурий") { }
        public override string Check(Student student)
        {
            if (student.TestScore >= TestScore)
            {
                return "Готов(а) к миссии!";
            }
            return "Не готов(а) к миссии!";
        }
    }
}
