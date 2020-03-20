using System;
using System.Xml.Serialization;

namespace Cw2.poco.xml
{
    [Serializable]
    public class StudentXml
    {
        [XmlAttribute(AttributeName = "indexNumber")]
        public string IndexNumber { get; set; }

        [XmlElement(ElementName = "fname")] public string FirstName { get; set; }
        [XmlElement(ElementName = "lName")] public string LastName { get; set; }

        [XmlElement(ElementName = "birthdate")]
        public string DateOfBirth { get; set; }

        [XmlElement(ElementName = "email")] public string Email { get; set; }

        [XmlElement(ElementName = "mothersName")]
        public string MothersName { get; set; }

        [XmlElement(ElementName = "fathersName")]
        public string FathersName { get; set; }

        [XmlElement(ElementName = "studies")] public StudiesXml Studies { get; set; }
    }
}