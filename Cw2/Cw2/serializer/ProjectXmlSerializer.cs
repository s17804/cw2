using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Cw2.serializer
{
    public class ProjectXmlSerializer<T>
    {
        private readonly XmlSerializer _xmlSerializer;
        private readonly XmlSerializerNamespaces _xmlSerializerNamespaces;
        private XmlWriter _xmlWriter;

        public ProjectXmlSerializer()
        {
            _xmlSerializer = new XmlSerializer(typeof(T));
            _xmlSerializerNamespaces = new XmlSerializerNamespaces();
            _xmlSerializerNamespaces.Add(string.Empty, string.Empty);
        }

        public void SerializeToXml(T parameter, string outputPath)
        {
            var fileStream = new FileStream(outputPath, FileMode.Create);
            var xmlWriterSettings = new XmlWriterSettings
            {
                NewLineOnAttributes = false, Indent = true, OmitXmlDeclaration = true
            };
            _xmlWriter = XmlWriter.Create(fileStream, xmlWriterSettings);
            _xmlSerializer.Serialize(_xmlWriter, parameter, _xmlSerializerNamespaces);
        }
    }
}