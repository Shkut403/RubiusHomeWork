using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lesson9
{ 
    class Program
    {
        static void Main()
        {
            string appDataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lesson12Homework.txt");

            string csvFilePath = File.ReadAllText(appDataFilePath);

            List<FileInfoRecord> records = new List<FileInfoRecord>();
            using (StreamReader sr = new StreamReader(csvFilePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var parts = line.Split('\t');
                    records.Add(new FileInfoRecord(parts[0], parts[1], DateTime.Parse(parts[2])));
                }
            }

            foreach (var record in records.OrderBy(r => r.LastModified))
            {
                Console.WriteLine($"{record.Type}\t{record.Name}\t{record.LastModified}");
            }

            File.Delete(appDataFilePath);
        }
    }
}