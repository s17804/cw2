using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Cw2.constants;

namespace Cw2.poco.json
{
    [Serializable]
    public class UniversityJson
    {
        [JsonPropertyName("createdAt")] public string CreationDate { get; set; }

        [JsonPropertyName("author")] public string Author { get; set; }

        [JsonPropertyName("studenci")] public List<StudentJson> Students { get; set; }

        [JsonPropertyName("activeStudies")] public List<ActiveStudiesJson> ActiveStudies { get; set; }

        public UniversityJson()
        {
            CreationDate = DateTime.Today.ToString("dd.MM.yyyy");
            Author = ProjectConstants.Author;
        }
    }
}