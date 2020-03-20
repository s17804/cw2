using System.Collections.Generic;

namespace Cw2.poco
{
    public class Student
    {
        public string IndexNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string DateOfBirth { get; }
        public string Email { get; }
        public string MothersName { get; }
        public string FathersName { get; }
        public StudiesDto Studies { get; }

        public Student(string indexNumber, string firstName, string lastName, string dateOfBirth, string email,
            string mothersName, string fathersName, string studiesName, string studiesMode)
        {
            IndexNumber = indexNumber;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            MothersName = mothersName;
            FathersName = fathersName;
            Studies = new StudiesDto(studiesName, studiesMode);
        }

        public Student(IReadOnlyList<string> line) :
            this(line[4], line[0], line[1], line[5], line[6],
                line[7], line[8], line[2], line[3])
        {
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student student))
            {
                return false;
            }

            return IndexNumber.Equals(student.IndexNumber)
                   && FirstName.Equals(student.FirstName)
                   && LastName.Equals(student.LastName);
        }

        public override int GetHashCode()
        {
            return IndexNumber.GetHashCode() +
                   FirstName.GetHashCode() +
                   LastName.GetHashCode();
        }

        public override string ToString()
        {
            return "IndexNumber=" + IndexNumber +
                   ", FirstName=" + FirstName +
                   ", LastName=" + LastName +
                   ", DateOfBirth=" + DateOfBirth +
                   ", Email=" + Email +
                   ", MothersName=" + MothersName +
                   ", FathersName=" + FathersName +
                   ", Studies=(" + Studies + ")";
        }
    }
}