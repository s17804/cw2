using System;
using System.Xml.Serialization;

namespace Cw2.poco.xml
{
    [Serializable]
    public class StudiesXml
    {
        [XmlElement("name")] public string StudiesName { get; set; }
        [XmlElement("mode")] public string StudiesMode { get; set; }

        public StudiesXml()
        {
        }

        public StudiesXml(string name, string mode)
        {
            StudiesName = name;
            StudiesMode = mode;
        }
    }
}