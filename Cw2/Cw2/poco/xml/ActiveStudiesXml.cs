using System;
using System.Xml.Serialization;

namespace Cw2.poco.xml
{
    [Serializable]
    public class ActiveStudiesXml
    {
        [XmlAttribute("name")] public string StudiesName { get; set; }
        [XmlAttribute("numberOfStudents")] public int NumberOfStudents { get; set; }

        public ActiveStudiesXml()
        {
        }

        public ActiveStudiesXml(string studiesName, int numberOfStudents)
        {
            StudiesName = studiesName;
            NumberOfStudents = numberOfStudents;
        }
    }
}