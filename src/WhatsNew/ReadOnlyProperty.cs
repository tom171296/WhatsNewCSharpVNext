using System.Text.Json.Serialization;

namespace WhatsNew;

[JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
class CustomerInfo
{
    // Both of these properties are read-only.
    public List<string> Names { get; } = new();
    public CompanyInfo Company { get; } = new() { Name = "N/A", PhoneNumber = "N/A" };
    public string Address { get; } = "N/A";
}

class CompanyInfo
{
    public required string Name { get; set; }
    public string? PhoneNumber { get; set; }
}



