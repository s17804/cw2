namespace Cw2.poco
{
    public class StudiesDto
    {
        public string StudiesName { get; }
        public string StudiesMode { get; }

        public StudiesDto(string name, string mode)
        {
            StudiesName = name;
            StudiesMode = mode;
        }

        public override string ToString()
        {
            return "StudiesName=" + StudiesName +
                   ", StudiesMode=" + StudiesMode;
        }
    }
}