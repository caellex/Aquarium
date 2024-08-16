namespace Aquarium
{
    internal class Program
    {
        static void Main()
        {

            Aquarium aquarium = new Aquarium();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Aquarium!\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1) Look into the aquarium");
                Console.WriteLine("2) Exit App");

                char menuChoice = Console.ReadKey(true).KeyChar;

                if (Int32.TryParse(menuChoice.ToString(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            aquarium.VisitAquarium();
                            break;
                        case 2:
                            Environment.Exit(52);
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The key '{menuChoice.ToString().ToUpper()}' is not a valid option. Please try again.");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }
        }
    }
}
