using System.Collections.Generic;
using Cw2.poco.xml;

namespace Cw2.services
{
    public class XmlDocumentService
    {
        private readonly StudiesService _studiesService;

        public XmlDocumentService()
        {
            _studiesService = new StudiesService();
        }

        public XmlDocumentRoot CreateXmlDocumentRoot(List<StudentXml> studentList)
        {
            return new XmlDocumentRoot
            {
                Students = studentList, ActiveStudies = _studiesService.GetStudiesTypeAndCount(studentList)
            };
        }
    }
}