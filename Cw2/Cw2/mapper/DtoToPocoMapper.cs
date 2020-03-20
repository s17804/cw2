using Cw2.poco;
using Cw2.poco.json;
using Cw2.poco.xml;

namespace Cw2.mapper
{
    public static class DtoToPocoMapper
    {
        public static StudentXml MapStudentDtoToXmlPoco(Student student)
        {
            return new StudentXml
            {
                IndexNumber = student.IndexNumber,
                FirstName = student.FirstName,
                LastName = student.LastName,
                DateOfBirth = student.DateOfBirth,
                Email = student.Email,
                MothersName = student.MothersName,
                FathersName = student.FathersName,
                Studies = MapStudiesDtoToXmlPoco(student.Studies)
            };
        }

        public static StudentJson MapStudentDtoToJsonPoco(Student student)
        {
            return new StudentJson
            {
                IndexNumber = student.IndexNumber,
                FirstName = student.FirstName,
                LastName = student.LastName,
                DateOfBirth = student.DateOfBirth,
                Email = student.Email,
                MothersName = student.MothersName,
                FathersName = student.FathersName,
                Studies = MapStudiesDtoToJsonPoco(student.Studies)
            };
        }


        public static StudiesXml MapStudiesDtoToXmlPoco(StudiesDto studiesDto)
        {
            return new StudiesXml
            {
                StudiesName = studiesDto.StudiesName,
                StudiesMode = studiesDto.StudiesMode
            };
        }

        public static StudiesJson MapStudiesDtoToJsonPoco(StudiesDto studiesDto)
        {
            return new StudiesJson
            {
                StudiesName = studiesDto.StudiesName,
                StudiesMode = studiesDto.StudiesMode
            };
        }
    }
}