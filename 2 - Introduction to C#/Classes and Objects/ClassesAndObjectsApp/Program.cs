public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = Age;
    }

    public void Greet()
    {
        Console.WriteLine("Hi " + Name);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person marlos = new Person("Marlos", 30);
        Person maciel = new Person("Maciel", 30);
        marlos.Greet();
        maciel.Greet();
    }
}