﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Clownfish : Fish
    {
        private string _name;
        private int _age;
        public Clownfish(string species, string name, int age) : base(species)
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
