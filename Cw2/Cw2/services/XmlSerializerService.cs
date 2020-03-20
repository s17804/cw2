using Cw2.constants;
using Cw2.poco.xml;
using Cw2.serializer;
using Cw2.utils;

namespace Cw2.services
{
    public class XmlSerializerService
    {
        private readonly ProjectXmlSerializer<XmlDocumentRoot> _projectXmlSerializer;
        private readonly XmlDocumentService _xmlDocumentService;
        private readonly StudentService _studentService;
        private readonly FileService _fileService;

        public XmlSerializerService()
        {
            _projectXmlSerializer = new ProjectXmlSerializer<XmlDocumentRoot>();
            _xmlDocumentService = new XmlDocumentService();
            _studentService = new StudentService();
            _fileService = new FileService();
        }

        public void SerializeToXml(string inputPath, string outputPath)
        {
            if (!ValidationUtils.ValidatePath(inputPath))
            {
                inputPath = ProjectConstants.InputFileDefaultPath;
            }

            if (!ValidationUtils.ValidatePath(outputPath))
            {
                outputPath = ProjectConstants.OutputXmlFileDefaultPath;
            }

            _projectXmlSerializer.SerializeToXml(
                _xmlDocumentService.CreateXmlDocumentRoot(
                    _studentService.ConvertStudentDtoListToXmlStudentList(_fileService.ReadFile(inputPath))),
                outputPath);
        }
    }
}