using Lesson9;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Lesson9
{ 
    class Program
    {
        static void Main()
        {
            string archivePath = "C:/Users/3DS_Asus/source/archive.zip";  // Указать путь к архиву
            string extractPath = Path.Combine(Directory.GetCurrentDirectory(), "extracted");
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "files.csv");
            string appDataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lesson12Homework.txt");

            ZipFile.ExtractToDirectory(archivePath, extractPath);

            List<FileInfoRecord> records = new List<FileInfoRecord>();
            foreach (var directory in Directory.GetDirectories(extractPath))
            {
                var dirInfo = new DirectoryInfo(directory);
                records.Add(new FileInfoRecord("Folder", dirInfo.Name, dirInfo.LastWriteTime));
            }

            foreach (var file in Directory.GetFiles(extractPath))
            {
                var fileInfo = new FileInfo(file);
                records.Add(new FileInfoRecord("File", fileInfo.Name, fileInfo.LastWriteTime));
            }

            using (StreamWriter sw = new StreamWriter(csvFilePath))
            {
                foreach (var record in records)
                {
                    sw.WriteLine($"{record.Type}\t{record.Name}\t{record.LastModified}");
                }
            }

            Directory.Delete(extractPath, true);

            File.WriteAllText(appDataFilePath, csvFilePath);
        }
    }
}