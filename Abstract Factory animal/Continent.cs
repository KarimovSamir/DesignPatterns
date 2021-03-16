namespace Abstract_Factory_animal
{
    abstract class Continent
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Predator CreatePredator();
    }
}
