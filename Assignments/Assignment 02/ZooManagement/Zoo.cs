namespace ZooManagement
{
    // The Zoo class represents a collection of Habitat objects, an example of Aggregation.
    // Aggregation is a type of Association where the aggregate (Zoo) can exist independently of the parts (Habitats).
    public class Zoo
    {
        // The Habitats property is a List<Habitat>, a collection of different habitats present in the zoo.
        private List<Habitat> Habitats { get; set; }
        // The AnimalsInventory property is a Dictionary<Guid, Animal>, a collection of all animals present in the zoo,
        // it maps the unique ID of an animal to its corresponding Animal object. This allows for fast lookup of animals.
        private Dictionary<Guid, Animal> AnimalsInventory { get; set; }
        // The AnimalCountByType property is a Dictionary<string, int>, a collection that maps a string (the species of animal)
        // to an integer (the count of animals of that species). This is useful for keeping track of the number of each type of animal in the zoo.
        private Dictionary<string, int> AnimalCountByType { get; set; }

        public Zoo()
        {
            Habitats = new List<Habitat>();
            AnimalsInventory = new Dictionary<Guid, Animal>();
            AnimalCountByType = new Dictionary<string, int>();
        }

        public void AddHabitat(Habitat habitat)
        {
            Habitats.Add(habitat);
        }

        public void UpdateAnimalCounts()
        {
            foreach (var habitat in Habitats)
            {
                foreach (var animal in habitat.GetAnimals().Values)
                {
                    AnimalsInventory.Add(animal.ID, animal);
                    if (AnimalCountByType.ContainsKey(animal.Species))
                        AnimalCountByType[animal.Species]++;
                    else
                        AnimalCountByType.Add(animal.Species, 1);
                }
            }
        }

        // A method to get the count of animals by type
        public int GetAnimalCountByType(string species)
        {
            if (AnimalCountByType.ContainsKey(species))
                return AnimalCountByType[species];
            else
                return 0;
        }

        // The FeedAllAnimals method is used to feed all animals in the zoo.
        public void FeedAllAnimals()
        {
            Console.WriteLine("\nFeeding all animals...\n");
            foreach (var habitat in Habitats)
            {
                Console.WriteLine($"In {habitat.Name} habitat:");
                foreach (var animal in habitat.GetAnimals().Values) // Notice the .Values here
                {
                    animal.Eat();
                }
                Console.WriteLine();
            }
        }

        // The MakeAllAnimalsSound method uses the ISoundBehaviour interface.
        // This is another example of Polymorphism. At runtime, the appropriate method will be called depending on the actual object type.
        public void MakeAllAnimalsSound()
        {
            Console.WriteLine("\nMaking all animals sound...\n");
            foreach (var habitat in Habitats)
            {
                Console.WriteLine($"In {habitat.Name} habitat:");
                foreach (var pair in habitat.GetAnimals()) // We get KeyValuePair<Guid, Animal>
                {
                    var animal = pair.Value; // Get the animal from the pair
                    if (animal is ISoundBehaviour soundMakingAnimal)
                    {
                        soundMakingAnimal.MakeSound();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}