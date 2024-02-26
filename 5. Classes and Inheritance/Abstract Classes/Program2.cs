using System;

public abstract class Animal
{
    public abstract string Sound { get; }

    public virtual void Move()
    {
        Console.WriteLine("Moving...");
    }
}

public class Cat : Animal
{
    public override string Sound => "Meow";

    public override void Move()
    {
        Console.WriteLine("Walking like a cat...");
    }
}

public class Dog : Animal
{
    public override string Sound => "Woof";

    public override void Move()
    {
        Console.WriteLine("Running like a dog...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[] { new Cat(), new Dog() };

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");
            animal.Move();
        }

        Console.ReadKey();
    }
}
