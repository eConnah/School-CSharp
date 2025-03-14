namespace FarmOOP
{
    public abstract class Animal
    {
        protected string animal;
        protected static Random random = new();
        protected int age;
        protected bool isFemale;
        protected bool isThirsty;
        protected bool isHungry;
        protected int happiness;

        public Animal(string animal, bool isFemale)
        {
            this.animal = animal;
            this.isFemale = isFemale;
        }

        public void Feed()
        {
            isHungry = false;
        }

        public void Hydrate()
        {
            isThirsty = false;
        }
    }
}