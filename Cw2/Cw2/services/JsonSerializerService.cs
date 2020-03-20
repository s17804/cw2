using Cw2.constants;
using Cw2.poco.json;
using Cw2.serializer;
using Cw2.utils;

namespace Cw2.services
{
    public class JsonSerializerService
    {
        private readonly StudentService _studentService;
        private readonly ProjectJsonSerializer<DocumentJson> _projectJsonSerializer;
        private readonly JsonDocumentService _jsonDocumentService;
        private readonly FileService _fileService;

        public JsonSerializerService()
        {
            _studentService = new StudentService();
            _projectJsonSerializer = new ProjectJsonSerializer<DocumentJson>();
            _jsonDocumentService = new JsonDocumentService();
            _fileService = new FileService();
        }

        public void SerializeToJson(string inputPath, string outputPath)
        {
            if (!ValidationUtils.ValidatePath(inputPath))
            {
                inputPath = ProjectConstants.InputFileDefaultPath;
            }

            if (!ValidationUtils.ValidatePath(outputPath))
            {
                outputPath = ProjectConstants.OutputJsonFileDefaultPath;
            }

            _projectJsonSerializer.SerializeToJson(
                _jsonDocumentService.CreateJsonDocumentRoot(
                    _studentService.ConvertStudentDtoListToJsonStudentList(_fileService.ReadFile(inputPath))),
                outputPath);
        }
    }
}