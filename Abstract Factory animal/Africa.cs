namespace Abstract_Factory_animal
{
    class Africa : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Zebra();
        }
        public override Predator CreatePredator()
        {
            return new Lion();
        }
    }
}
