using System;
using System.Text.Json;
using System.IO;
using System.Text;

namespace PastriesDelivery
{
    public class StorageSerializer
    {
        public string FileName { get; set; }
        
        public void SaveToJsonFile(IStorage storage)
        {
            var serializedStorage = JsonSerializer.Serialize(storage);
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;
            using var file = new FileStream(path, FileMode.OpenOrCreate);
            using var StreamWriter = new StreamWriter(file, Encoding.UTF8);
            StreamWriter.Write(serializedStorage);
        }

        public Storage ExtractFomJsonFile()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + FileName;
            using var file = new FileStream(path, FileMode.OpenOrCreate);
            using var stream = new StreamReader(file, Encoding.UTF8);
            var storage = stream.ReadToEnd();
            return JsonSerializer.Deserialize<Storage>(storage);

        }
    }
}
