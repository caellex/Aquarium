using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Goldfish : Fish
    {
        private string _name;
        private int _age;
        public Goldfish(string species, string name, int age) : base(species)
        {
            _name = name;
            _age = age;
        }

        
        public void GetInfoAboutFish()
        {
            base.LookCloserAtFish();
            Console.Write($" named {_name} it looks like it might be {_age} year(s) old.");
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
