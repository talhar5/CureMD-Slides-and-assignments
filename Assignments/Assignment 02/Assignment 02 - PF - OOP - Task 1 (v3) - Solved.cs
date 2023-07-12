using System;
using System.Collections.Generic;

public interface ISoundBehaviour
{
    void MakeSound();
}

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} the {Species} is eating.");
    }

    public void Eat(string food)
    {
        Console.WriteLine($"{Name} the {Species} is eating {food}.");
    }
}

public class Lion : Animal, ISoundBehaviour
{
    public Lion(string name, int age, Habitat habitat) : base(name, age, "Lion")
    {
        habitat.AddAnimal(this);
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Lion is eating meat.");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion is roaring!");
    }
}

public class Elephant : Animal, ISoundBehaviour
{
    public Elephant(string name, int age, Habitat habitat) : base(name, age, "Elephant")
    {
        habitat.AddAnimal(this);
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

public class Monkey : Animal, ISoundBehaviour
{
    public Monkey(string name, int age, Habitat habitat) : base(name, age, "Monkey")
    {
        habitat.AddAnimal(this);
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

public class Fish : Animal
{
    public Fish(string name, int age, Habitat habitat) : base(name, age, "Fish")
    {
        habitat.AddAnimal(this);
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Fish is eating seaweed.");
    }
}

public class Habitat
{
    public string Name { get; set; }
    private List<Animal> Animals { get; set; }

    public Habitat(string name)
    {
        Name = name;
        Animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public List<Animal> GetAnimals()
    {
        return Animals;
    }
}

public class Zoo
{
    private List<Habitat> Habitats { get; set; }

    public Zoo()
    {
        Habitats = new List<Habitat>();
    }

    public void AddHabitat(Habitat habitat)
    {
        Habitats.Add(habitat);
        Console.WriteLine($"Habitat {habitat.Name} has been added to the zoo.");
    }

    public void FeedAllAnimals()
    {
        foreach (var habitat in Habitats)
        {
            foreach (var animal in habitat.GetAnimals())
            {
                animal.Eat();
            }
        }
    }

    public void MakeAllAnimalsSound()
    {
        foreach (var habitat in Habitats)
        {
            foreach (var animal in habitat.GetAnimals())
            {
                if (animal is ISoundBehaviour soundMakingAnimal)
                {
                    soundMakingAnimal.MakeSound();
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        Habitat savannah = new Habitat("Savannah");
        Habitat jungle = new Habitat("Jungle");
        Habitat pond = new Habitat("Pond");

        zoo.AddHabitat(savannah);
        zoo.AddHabitat(jungle);
        zoo.AddHabitat(pond);

        Lion lion = new Lion("Simba", 5, savannah);
        Elephant elephant = new Elephant("Dumbo", 8, savannah);
        Monkey monkey = new Monkey("George", 3, jungle);
        Fish fish = new Fish("Nemo", 2, pond);

        zoo.FeedAllAnimals();
        zoo.MakeAllAnimalsSound();


        Console.ReadKey();
    }
}