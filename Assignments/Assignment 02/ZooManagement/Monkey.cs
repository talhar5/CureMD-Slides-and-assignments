namespace ZooManagement
{
    public class Monkey : Animal, ISoundBehaviour
    {
        public Monkey(string name, int age, Habitat habitat) : base(name, age, "Monkey")
        {
            habitat.AddAnimal(this);
            Console.WriteLine($"Added {Name} the {Species} to the {habitat.Name} habitat.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the Monkey is eating bananas.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} the Monkey is chattering!");
        }
    }
}