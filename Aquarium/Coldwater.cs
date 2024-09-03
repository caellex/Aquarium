using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Coldwater : Fish
    {
        private int _fromDegrees;
        private int _toDegrees;

        public Coldwater(int from, int to, Species species, string name, int age) : base(species, name, age)
        {
            _fromDegrees = from;
            _toDegrees = to;
        }

        public override void LookCloserAtFish()
        {
            base.LookCloserAtFish();
            Console.WriteLine($"It generally thrives in temperatures between {_fromDegrees}° - {_toDegrees}°");
        }
    }
}
