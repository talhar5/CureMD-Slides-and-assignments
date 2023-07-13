namespace ZooManagement
{
    // Declaring an abstract class Animal. This is a form of abstraction in OOP.
    // Abstraction allows complex real-world concepts to be represented in a simplified manner in a program.
    // Animal class represents general characteristics of all animals.
    public abstract class Animal
    {
        // Properties are an example of encapsulation where you can have data validation inside getters and setters 
        // Here, however, we are using auto-implemented properties with default getters and setters.

        // The Guid data type is used to generate a unique identifier (ID) for each Animal object.
        public Guid ID { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        // This is a constructor method for the Animal class, encapsulating the creation of an animal.
        // Encapsulation protects the data from outside interference and misuse.
        public Animal(string name, int age, string species)
        {
            ID = Guid.NewGuid(); // Assign a unique ID to each animal
            Name = name;
            Age = age;
            Species = species;
        }

        // This is a virtual method, allowing for the method to be overridden in subclasses.
        // This is another form of Polymorphism. The code will call the appropriate method depending on the actual object type at runtime.
        public virtual void Eat()
        {
            Console.WriteLine($"{Name} the {Species} is eating.");
        }
    }
}
