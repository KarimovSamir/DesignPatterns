namespace Abstract_Factory_animal
{
    class World
    {
        private Herbivore herbivore;
        private Predator predator;

        public World(Continent continent)
        {
            predator = continent.CreatePredator();
            herbivore = continent.CreateHerbivore();
        }

        public void AnimalFood()
        {
            herbivore.Eat();
            predator.Eat(herbivore);
        }
    }
}
