namespace ZooManagement
{
    // The Lion class is a derived class from Animal. This is Inheritance.
    // Inheritance allows a class to have the properties and methods of another class.
    // Lion is also implementing the ISoundBehaviour interface, so it must provide an implementation for MakeSound.
    public class Lion : Animal, ISoundBehaviour
    {
        // This is the constructor for the Lion class, which calls the base class constructor.
        // The "base" keyword is used to access members in the base class from within the derived class.
        public Lion(string name, int age, Habitat habitat) : base(name, age, "Lion")
        {
            habitat.AddAnimal(this);  // Interacting with another object (the habitat), this is an aspect of object-oriented programming.
            Console.WriteLine($"Added {Name} the {Species} to the {habitat.Name} habitat.");
        }

        // This method overrides the virtual method from the parent class.
        // This is another example of Polymorphism.
        public override void Eat()
        {
            Console.WriteLine($"{Name} the Lion is eating meat.");
        }

        // This method provides the implementation for the ISoundBehaviour interface.
        // This is an example of Polymorphism. At runtime, the appropriate method will be called depending on the actual object type.
        public void MakeSound()
        {
            Console.WriteLine($"{Name} the Lion is roaring!");
        }
    }
}