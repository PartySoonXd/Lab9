    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Jupiter : Planet, IRequireSamples
    {
        public int SamplesCount { get; set; } = 11;
        public Jupiter() : base("Юпитер") { }
        public override string Check(Student student)
        {
            if (student.SamplesCount >= SamplesCount)
            {
                return "Готов(а) к миссии!";
            }
            return "Не готов(а) к миссии!";
        }
    }
}
