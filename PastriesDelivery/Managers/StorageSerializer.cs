using System;
using System.Text.Json;
using System.IO;
using System.Text;

namespace PastriesDelivery
{
    public static class StorageSerializer
    {
        private static string fileName = "serialized_storage.json";

        public static void SaveToJsonFile(IStorage storage)
        {
            var serializedStorage = JsonSerializer.Serialize(storage);
            var path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            using var file = new FileStream(path, FileMode.OpenOrCreate);
            using var StreamWriter = new StreamWriter(file, Encoding.UTF8);
            StreamWriter.Write(serializedStorage);
        }

        public static Storage ExtractFomJsonFile()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            using var file = new FileStream(path, FileMode.OpenOrCreate);
            using var stream = new StreamReader(file, Encoding.UTF8);
            var storage = stream.ReadToEnd();
            if (String.IsNullOrEmpty(storage))
            {
                return new Storage();
            }
            return JsonSerializer.Deserialize<Storage>(storage);
        }
    }
}
