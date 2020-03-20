using System;
using System.Collections.Generic;
using System.Linq;
using Cw2.constants;
using Cw2.mapper;
using Cw2.poco;
using Cw2.poco.json;
using Cw2.poco.xml;

namespace Cw2.services
{
    public class StudentService
    {
        public StudentXml MapStudentDtoToXmlPoco(Student student)
        {
            return DtoToPocoMapper.MapStudentDtoToXmlPoco(student);
        }
        
        public StudentJson MapStudentDtoToJsonPoco(Student student)
        {
            return DtoToPocoMapper.MapStudentDtoToJsonPoco(student);
        }

        private string FormatDate(string date)
        {
            return Convert.ToDateTime(date).ToString("dd.MM.yyyy");
        }

        public List<Student> RemoveDistinct(List<Student> studentDtoList)
        {
            return studentDtoList.Distinct().ToList();
        }

        public List<StudentXml> ConvertStudentDtoListToXmlStudentList(List<Student> studentDtoList)
        {
            var studentListDistinct = RemoveDistinct(studentDtoList);
            return studentListDistinct.Select(MapStudentDtoToXmlPoco).ToList();
        }
        
        public List<StudentJson> ConvertStudentDtoListToJsonStudentList(List<Student> studentDtoList)
        {
            var studentListDistinct = RemoveDistinct(studentDtoList);
            return studentListDistinct.Select(MapStudentDtoToJsonPoco).ToList();
        }

        public Student CreateNewStudent(string line)
        {
            var lineArray = line.Split(ProjectConstants.DataSeparator); 
            lineArray[ReturnIndex("IndexNumber")] = FormatIndexNumber(lineArray[ReturnIndex("IndexNumber")]);
            lineArray[ReturnIndex("DateOfBirth")] = FormatDate(lineArray[ReturnIndex("DateOfBirth")]);
            return new Student(lineArray);
        }
        
        private string FormatIndexNumber(string index)
        {
            if (!(index.FirstOrDefault() == 's' || index.FirstOrDefault() == 'S'))
            {
                index = "s" + index;
            }
            else
            {
                index = index.ToLower();
            }

            return index;
        }
        
        private static int ReturnIndex(string name)
        {
            return ProjectConstants.ReturnElementIndex(name);
        }
    }
}