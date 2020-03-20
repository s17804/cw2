using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace Cw2.serializer
{
    public class ProjectJsonSerializer<T>
    {
        public void SerializeToJson(T parameter, string outputPath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            File.WriteAllText(outputPath, JsonSerializer.Serialize(parameter, options));
        }
    }
}