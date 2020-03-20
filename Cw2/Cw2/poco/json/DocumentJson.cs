using System;
using System.Text.Json.Serialization;

namespace Cw2.poco.json
{
    [Serializable]
    public class DocumentJson
    {
        [JsonPropertyName("uczelnia")] public UniversityJson University { get; set; }

        public DocumentJson(UniversityJson university)
        {
            University = university;
        }

        public DocumentJson()
        {
        }
    }
}