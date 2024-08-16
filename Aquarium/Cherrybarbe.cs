using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aquarium
{
    internal class Cherrybarbe : Fish
    {
        private string _name;
        private int _age;

        public Cherrybarbe(string species, string name, int age) : base(species = "Cherrybarbe")
        {
            _name = name;
            _age = age;
        }
        public override string GetName()
        {
            return _name;
        }

        public override int GetAge()
        {
            return _age;
        }
    }
}
