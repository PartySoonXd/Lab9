using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Venus : Planet, IHaveAngryResidents
    {
        public string Message { get; } = "На этой планете живут агрессивные жители, миссия невозможна!";
        public Venus() : base("Венера") { }
        public override string Check(Student student)
        {
            return Message;
        }
    }
}
