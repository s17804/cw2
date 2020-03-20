using System.Collections.Generic;
using System.IO;
using Cw2.poco;
using Cw2.utils;

namespace Cw2.services
{
    public class FileService
    {
        public readonly StudentService _studentService;

        public FileService()
        {
            _studentService = new StudentService();
        }

        public List<Student> ReadFile(string inputPath)
        {
            using var inputStream = new StreamReader(File.OpenRead(inputPath));
            string line;
            var studentDtoList = new List<Student>();
            while ((line = inputStream.ReadLine()) != null)
            {
                if (!ValidationUtils.ValidateStudentDto(line)) continue;
                var student = _studentService.CreateNewStudent(line);
                studentDtoList.Add(student);
            }

            return studentDtoList;
        }
    }
}