using System;

namespace Abstract_Factory_animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Africa: ");
            Continent africa = new Africa();
            World world = new World(africa);
            world.AnimalFood();

            Console.WriteLine();

            Console.WriteLine("In North America: ");
            Continent america = new NorthAmerica();
            world = new World(america);
            world.AnimalFood();
        }
    }
}
