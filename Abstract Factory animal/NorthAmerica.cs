namespace Abstract_Factory_animal
{
    class NorthAmerica : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Deer();
        }
        public override Predator CreatePredator()
        {
            return new Bear();
        }
    }
}
