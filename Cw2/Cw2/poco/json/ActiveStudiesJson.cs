using System;
using System.Text.Json.Serialization;

namespace Cw2.poco.json
{
    [Serializable]
    public class ActiveStudiesJson
    {
        [JsonPropertyName("name")] public string StudiesName { get; set; }
        [JsonPropertyName("numberOfStudents")] public int NumberOfStudents { get; set; }

        public ActiveStudiesJson()
        {
        }

        public ActiveStudiesJson(string studiesName, int numberOfStudents)
        {
            StudiesName = studiesName;
            NumberOfStudents = numberOfStudents;
        }
    }
}