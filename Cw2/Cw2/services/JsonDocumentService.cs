using System.Collections.Generic;
using Cw2.poco.json;

namespace Cw2.services
{
    public class JsonDocumentService
    {
        private readonly StudiesService _studiesService;

        public JsonDocumentService()
        {
            _studiesService = new StudiesService();
        }

        public DocumentJson CreateJsonDocumentRoot(List<StudentJson> studentList)
        {
            return new DocumentJson
            {
                University = new UniversityJson
                {
                    Students = studentList, ActiveStudies = _studiesService.GetStudiesTypeAndCount(studentList)
                }
            };
        }
    }
}