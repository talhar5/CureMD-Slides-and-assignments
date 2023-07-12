using System;
using System.Collections.Generic;

public class Animal
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
}

public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "Lion")
    { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Lion is eating meat.");
    }

    public void Roar()
    {
        Console.WriteLine($"{Name} the Lion is roaring!");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "Elephant")
    { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Elephant is eating peanuts.");
    }

    public void Trumpet()
    {
        Console.WriteLine($"{Name} the Elephant is trumpeting!");
    }
}

public class Monkey : Animal
{
    public Monkey(string name, int age) : base(name, age, "Monkey")
    { }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the Monkey is eating bananas.");
    }

    public void Climb()
    {
        Console.WriteLine($"{Name} the Monkey is climbing a tree!");
    }
}

public class Zoo
{
    public List<Animal> Animals { get; set; }

    public Zoo()
    {
        Animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
        Console.WriteLine($"{animal.Name} the {animal.Species} has been added to the zoo.");
    }

    public void FeedAllAnimals()
    {
        foreach (var animal in Animals)
        {
            animal.Eat();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        Lion lion = new Lion("Simba", 5);
        Elephant elephant = new Elephant("Dumbo", 8);
        Monkey monkey = new Monkey("George", 3);

        zoo.AddAnimal(lion);
        zoo.AddAnimal(elephant);
        zoo.AddAnimal(monkey);
        zoo.FeedAllAnimals();


    }
}
