using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    abstract class Planet
    {
        public string Name { get; set; }

        public Planet(string name) 
        {
            Name = name;
        }
        public abstract string Check(Student student);
    }
}
