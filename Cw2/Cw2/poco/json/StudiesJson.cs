using System;
using System.Text.Json.Serialization;

namespace Cw2.poco.json
{
    [Serializable]
    public class StudiesJson
    {
        [JsonPropertyName("name")] public string StudiesName { get; set; }
        [JsonPropertyName("mode")] public string StudiesMode { get; set; }

        public StudiesJson()
        {
        }

        public StudiesJson(string name, string mode)
        {
            StudiesName = name;
            StudiesMode = mode;
        }
    }
}