using System.Collections.Generic;
using System.Linq;
using Cw2.poco.json;
using Cw2.poco.xml;

namespace Cw2.services
{
    public class StudiesService
    {
        public List<ActiveStudiesXml> GetStudiesTypeAndCount(IEnumerable<StudentXml> students)
        {
            var studiesGroups = students.GroupBy(s => s.Studies.StudiesName);
            return studiesGroups.Select(studies =>
                new ActiveStudiesXml(studies.Key, studies.Count()))
                .OrderByDescending(studies => studies.NumberOfStudents).ToList();
        }
        
        public List<ActiveStudiesJson> GetStudiesTypeAndCount(IEnumerable<StudentJson> students)
        {
            var studiesGroups = students.GroupBy(s => s.Studies.StudiesName);
            return studiesGroups.Select(studies =>
                    new ActiveStudiesJson(studies.Key, studies.Count()))
                .OrderByDescending(studies => studies.NumberOfStudents).ToList();
        }
    }
}