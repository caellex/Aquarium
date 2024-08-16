using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal abstract class Fish
    {
        private string _species;

        public Fish(string species)
        {
            _species = species;
        }

        public abstract string GetName();
        public abstract int GetAge();
        public virtual string GetSpecies()
        {
            return _species;
        }

        public virtual void LookCloserAtFish()
        {
            Console.WriteLine($"You look closer at the {_species} named {this.GetName()}. It looks to be {this.GetAge()} year(s) old.");
        }
    }
}
