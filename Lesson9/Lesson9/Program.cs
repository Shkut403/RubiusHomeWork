namespace Lesson9
{
    public class FileInfoRecord
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime LastModified { get; set; }

        public FileInfoRecord(string type, string name, DateTime lastModified)
        {
            Type = type;
            Name = name;
            LastModified = lastModified;
        }
    }
}