namespace Cw2.services
{
    public class SerializationChooserService
    {
        public void ChoseSerializationType(string inputPath, string outputPath, string outputType)
        {
            outputType = outputType.ToLower();
            switch (outputType)
            {
                case "json":
                    var jsonSerializationService = new JsonSerializerService();
                    jsonSerializationService.SerializeToJson(inputPath, outputPath);
                    break;

                default:
                    var xmlSerializerService = new XmlSerializerService();
                    xmlSerializerService.SerializeToXml(inputPath, outputPath);
                    break;
            }
        }
    }
}