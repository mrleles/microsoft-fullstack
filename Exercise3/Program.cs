class Program
{
    public static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        dog.MakeSound();
        cat.MakeSound();
    }
}

public class Animal()
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Making a sound");
    }
}

public class Dog() : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat() : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}