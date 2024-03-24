using Lesson9;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static async Task Main()
        {
            string archivePath = "C:/Users/3DS_Asus/source/archive.zip";  // Указать путь к архиву
            string extractPath = Path.Combine(Directory.GetCurrentDirectory(), "extracted");
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "files.csv");
            string appDataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lesson12Homework.txt");

            // Извлечение архива асинхронно не поддерживается напрямую, поэтому используем синхронный метод
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

            await using (StreamWriter sw = new StreamWriter(csvFilePath))
            {
                foreach (var record in records)
                {
                    await sw.WriteLineAsync($"{record.Type}\t{record.Name}\t{record.LastModified}");
                }
            }

            Directory.Delete(extractPath, true);

            await File.WriteAllTextAsync(appDataFilePath, csvFilePath);
        }
    }
}
