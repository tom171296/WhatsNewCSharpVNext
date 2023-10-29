// -------------------------//
// Serialization            //
// -------------------------//

// Read-only properties

// using System.Text.Json;
// using System.Text.Json.Serialization;
// using WhatsNew;

// var options = new JsonSerializerOptions{
//     PreferredObjectCreationHandling = JsonObjectCreationHandling.Populate
// };

// CustomerInfo customer =
//     JsonSerializer.Deserialize<CustomerInfo>("""{"Names":["John Doe"],"Company":{"Name":"Contoso"},"Address": "test" }""", options: options)!;

// Console.WriteLine(JsonSerializer.Serialize(customer));


// -------------------------//
// Primary constructor      //
// -------------------------//

var person = new PersonClass("John", "Doe");
person.FirstName = "Jane";

var x = person with { FirstName = "Jane" };

var personRecord = new PersonRecord("John", "Doe");
personRecord.FirstName = "Jane";

var y = personRecord with { FirstName = "Jane" };

public class PersonClass(string FirstName, string LastName) 
{
    public string FullName => $"{FirstName} {LastName}";
}

public record PersonRecord(string FirstName, string LastName) 
{
    public string FullName => $"{FirstName} {LastName}";
}
