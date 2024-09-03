using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aquarium
{
    internal class Aquarium
    {
        List<Fish> allFishInTank = new List<Fish>();


        public void VisitAquarium()
        {
            InitializeFish();

            PeekInside();


        }
        private void InitializeFish()
        {
            if (allFishInTank.Count <= 0)
            {
                allFishInTank.Add(new Coldwater(18, 24, Species.Goldfish, "Kåre", 2));
                allFishInTank.Add(new Warmwater(25, 28, Species.Dwarfgurami, "Mons", 10));
                allFishInTank.Add(new Warmwater(23, 26, Species.Cherrybarbe, "Kjetil", 5));
                allFishInTank.Add(new Coldwater(18, 24, Species.Goldfish, "Jens", 4));
                allFishInTank.Add(new Warmwater(22, 26, Species.Otto, "Svein-Kjetil Andrè", 8));
                allFishInTank.Add(new Warmwater(23, 26, Species.Clownfish, "Kari", 1));
                allFishInTank.Add(new Warmwater(25, 28, Species.Dwarfgurami, "Fisk", 3));
                allFishInTank.Add(new Warmwater(23, 26, Species.Cherrybarbe, "Anne", 1));
                allFishInTank.Add(new Warmwater(24, 28, Species.HoplisomaPanda, "Bob", 6));
                allFishInTank.Add(new Warmwater(22, 26, Species.Otto, "Jens-Arne", 0));
                allFishInTank.Add(new Warmwater(23, 26, Species.Clownfish, "Nora", 11));
                allFishInTank.Add(new Warmwater(24, 28, Species.HoplisomaPanda, "Carl", 7));
            }
        }

        private void PeekInside()
        {
            while (true)
            {
                SwimLogic();
                Console.WriteLine("\nIf you would like to look closer at a fish, type in it's name. If not, press X to exit.");
                string FishToFind = Console.ReadLine();

                if (FishToFind.ToUpper().Equals("X"))
                {
                    return;
                }

                FindFish(FishToFind);
            }
        }


        private void SwimLogic()
        {
            Random rand = new Random();
            var interval = rand.Next(200, 800);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            foreach (Fish fish in allFishInTank)
            {
                Console.WriteLine($"The {fish.GetSpecies()} {fish.GetName()} is swimming around, blob blob.");
                Thread.Sleep(interval);
            }
            Console.WriteLine();
            Console.ResetColor();
            Thread.Sleep(1000);
        }
        private void FindFish(string FishToFind)
        {
            Fish foundFish = allFishInTank.FirstOrDefault(fish => fish.GetName().Equals(FishToFind));

            if (foundFish != null)
            {
                foundFish.LookCloserAtFish();
                Thread.Sleep(4000);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"'{FishToFind}' is not an existing fish in this tank.");
                Console.ResetColor();
                Thread.Sleep(3000);
            }
        }
    }
}
