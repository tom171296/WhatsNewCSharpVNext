using System.Text.Json.Serialization;

namespace PrimayConstructor;

public class SubPerson(string lastname) : Person("")
{
}

public class Person(string fullname) // Primary constructor
{
    public string FullName { get; set; } = fullname;
}

public record PersonRecord(string Name)
{ 
    public void SayHello() {
        Console.WriteLine($"Hello, {Name}"); // access property
    } 
}

public class OldPerson{

    public OldPerson(string name) // Defaut way < c# 12
    {
        
    }
}


