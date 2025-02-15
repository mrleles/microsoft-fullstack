class Program
{
    public static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        dog.Eat();
        cat.Eat();

        List<Animal> animals = new List<Animal>();
        animals.Add(dog);
        animals.Add(cat);

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}

public interface IAnimal
{
    void Eat();
}

public class Animal() : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Making a sound");
    }

    public void Eat()
    {
        Console.WriteLine("Animal eating");
    }
}

public class Dog() : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public void Eat()
    {
        Console.WriteLine("Dog eating");
    }
}

public class Cat() : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public void Eat()
    {
        Console.WriteLine("Cat eating");
    }
}