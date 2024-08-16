using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Aquarium
    {
        List<Fish> allFishInTank = new List<Fish>();


        public void VisitAquarium()
        {
            Console.Clear();
            InitializeFish();

            PeekInside();
            
        }
        private void InitializeFish()
        {
            if(allFishInTank.Count <= 0)
            {
                allFishInTank.Add(new Goldfish("Goldfish","Kåre",2));
                allFishInTank.Add(new Dwarfgurami("Dwarfgurami", "Mons",10));
                allFishInTank.Add(new Cherrybarbe("Cherrybarbe", "Kjetil",5));
                allFishInTank.Add(new Goldfish("Goldfish","Jens",4));
                allFishInTank.Add(new Otto("Otto", "Svein-Kjetil Andrè",8));
                allFishInTank.Add(new Clownfish("Clownfish", "Kari",1));
                allFishInTank.Add(new Dwarfgurami("Dwarfgurami", "Fisk",3));
                allFishInTank.Add(new Cherrybarbe("Cherrybarbe","Anne",1));
                allFishInTank.Add(new Panda_pansermalle("Hoplisoma Panda", "Bob",6));
                allFishInTank.Add(new Otto("Otto", "Jens-Arne",0));
                allFishInTank.Add(new Clownfish("Clownfish", "Nora",11));
                allFishInTank.Add(new Panda_pansermalle("Hoplisoma Panda", "Carl",7));
            }
        }

        private void PeekInside()
        {
            while (true)
            {
                Console.Clear();
                SwimLogic();
                Console.WriteLine("\nIf you would like to look closer at a fish, type in it's name. If not, press X to exit.");
                string FishToFind = Console.ReadLine();

                if (FishToFind.ToUpper().Equals("X") )
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
                Thread.Sleep(2000);
            }
            else
            { 
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"'{FishToFind}' is not an existing fish in this tank.");
                Console.ResetColor();
                Thread.Sleep(2500);
            }
        }
    }
}
