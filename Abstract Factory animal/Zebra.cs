using System;

namespace Abstract_Factory_animal
{
    class Zebra : Herbivore
    {
        public override void Eat()
        {
            Console.WriteLine(GetType().Name + " eats plants");
        }
    }
}
