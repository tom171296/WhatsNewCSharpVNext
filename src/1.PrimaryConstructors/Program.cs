// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using PrimayConstructor;

Console.WriteLine("Hello, World!");


var person = new Person("Tom van den Berg");

var json = JsonSerializer.Serialize(person);
Console.WriteLine(json);

var personSerialized = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(personSerialized.FullName);