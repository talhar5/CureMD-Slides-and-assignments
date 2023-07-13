namespace ZooManagement
{
    // Similar explanations apply to Elephant, Monkey, and Fish classes. They are all practicing Inheritance, Polymorphism, and Encapsulation.
    public class Elephant : Animal, ISoundBehaviour
    {
        public Elephant(string name, int age, Habitat habitat) : base(name, age, "Elephant")
        {
            habitat.AddAnimal(this);
            Console.WriteLine($"Added {Name} the {Species} to the {habitat.Name} habitat.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} the Elephant is eating peanuts.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} the Elephant is trumpeting!");
        }
    }
}