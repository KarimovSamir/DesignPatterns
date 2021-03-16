using System;

namespace Abstract_Factory_animal
{
    class Lion : Predator
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}
