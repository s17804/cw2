using System;
using System.Text.Json.Serialization;

namespace Cw2.poco.json
{
    [Serializable]
    public class StudentJson
    {
        [JsonPropertyName("indexNumber")] public string IndexNumber { get; set; }
        [JsonPropertyName("fname")] public string FirstName { get; set; }
        [JsonPropertyName("lName")] public string LastName { get; set; }
        [JsonPropertyName("birthdate")] public string DateOfBirth { get; set; }
        [JsonPropertyName("email")] public string Email { get; set; }
        [JsonPropertyName("mothersName")] public string MothersName { get; set; }
        [JsonPropertyName("fathersName")] public string FathersName { get; set; }
        [JsonPropertyName("studies")] public StudiesJson Studies { get; set; }
    }
}