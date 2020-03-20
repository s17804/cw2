using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Cw2.constants;

namespace Cw2.poco.xml
{
    [Serializable, XmlRoot("uczelnia")]
    public class XmlDocumentRoot
    {
        [XmlAttribute(AttributeName = "createdAt")]
        public string CreationDate { get; set; }

        [XmlAttribute(AttributeName = "author")]
        public string Author { get; set; }

        [XmlArray("studenci"), XmlArrayItem("student")]
        public List<StudentXml> Students { get; set; }

        [XmlArray("activeStudies"), XmlArrayItem("studies")]
        public List<ActiveStudiesXml> ActiveStudies { get; set; }

        public XmlDocumentRoot()
        {
            CreationDate = DateTime.Today.ToString("dd.MM.yyyy");
            Author = ProjectConstants.Author;
        }
    }
}