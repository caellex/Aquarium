using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal enum Species
    {
        Goldfish,
        Clownfish,
        Dwarfgurami,
        HoplisomaPanda,
        Otto,
        Cherrybarbe,
    }
    internal abstract class Fish
    {
        private string _name;
        private int _age;
        private Species _species;

        public Fish(Species species, string name, int age)
        {
            _species = species;
            _name = name;
            _age = age; 
        }

        public virtual string GetName() {  return _name; }
        public virtual int GetAge() { return _age; }
        public virtual Species GetSpecies()
        {
            return _species;
        }

        public virtual void LookCloserAtFish()
        {
            Console.WriteLine($"You look closer at the {_species} named {this.GetName()}. It looks to be {this.GetAge()} year(s) old.");
        }
    }
}
