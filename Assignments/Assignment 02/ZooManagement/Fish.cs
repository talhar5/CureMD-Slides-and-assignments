namespace ZooManagement
{
    //The Fish Class doesn't implement the ISoundBehaviour interface as the Fish don't sounds
    public class Fish : Animal
    {
        public Fish(string name, int age, Habitat habitat) : base(name, age, "Fish")
        {
            habitat.AddAnimal(this);
            Console.WriteLine($"Added {Name} the {Species} to the {habitat.Name} habitat.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the Fish is eating seaweed.");
        }
    }
}