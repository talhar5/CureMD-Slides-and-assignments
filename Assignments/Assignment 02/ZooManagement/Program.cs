namespace ZooManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object creation: an instance of the Zoo class is created.
            // This is an example of the instantiation aspect of OOP where objects are instances of classes.
            Zoo zoo = new Zoo();

            // Object creation: instances of the Habitat class are created.
            // These are examples of abstraction where real-world concepts (habitats) are represented in code.
            Habitat savannah = new Habitat("Savannah");
            Habitat jungle = new Habitat("Jungle");
            Habitat pond = new Habitat("Pond");

            // Object interaction: the Zoo object interacts with Habitat objects using the AddHabitat method.
            // This is an example of method invocation and encapsulation where the implementation details are hidden and interaction occurs through methods.
            zoo.AddHabitat(savannah);
            zoo.AddHabitat(jungle);
            zoo.AddHabitat(pond);

            // Object creation and interaction: instances of various Animal-derived classes are created and added to the habitats.
            // This is an example of polymorphism (specifically subtype polymorphism) as each specific animal is treated as an Animal object.
            // Encapsulation is also demonstrated as the Animal objects interact with the Habitat objects through the AddAnimal method.
            Lion lion = new Lion("Simba", 5, savannah);
            lion = new Lion("Simba", 5, savannah);
            Elephant elephant = new Elephant("Dumbo", 8, savannah);
            Monkey monkey = new Monkey("George", 3, jungle);
            Fish fish = new Fish("Nemo", 2, pond);

            zoo.UpdateAnimalCounts();

            // Object interaction: the Zoo object interacts with the Animal and Habitat objects using the FeedAllAnimals and MakeAllAnimalsSound methods.
            // This is an example of method invocation, encapsulation, and polymorphism.
            // Polymorphism is displayed as the same method call results in different behaviors depending on the type of Animal.
            zoo.FeedAllAnimals();
            zoo.MakeAllAnimalsSound();

            // New line of code to demonstrate getting the count of animals by type
            Console.WriteLine($"\nNumber of Lions in the zoo: {zoo.GetAnimalCountByType("Lion")}");
            Console.WriteLine($"Number of Elephants in the zoo: {zoo.GetAnimalCountByType("Elephant")}");
            Console.WriteLine($"Number of Monkeys in the zoo: {zoo.GetAnimalCountByType("Monkey")}");
            Console.WriteLine($"Number of Fish in the zoo: {zoo.GetAnimalCountByType("Fish")}");
        }
    }

}