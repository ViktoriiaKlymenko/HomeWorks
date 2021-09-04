using EFCore.Data;
using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace PastriesDelivery
{
    public static class Serializer
    {
        private static string fileName = "serialized_storage.json";

        public static void SaveToJsonFile(DataContext dataContext)
        {
            var serializedStorage = JsonSerializer.Serialize(dataContext);
            var path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            using var file = new FileStream(path, FileMode.OpenOrCreate);
            using var streamWriter = new StreamWriter(file, Encoding.UTF8);
            streamWriter.Write(serializedStorage);
        }

        public static DataContext ExtractFomJsonFile()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            using var file = new FileStream(path, FileMode.OpenOrCreate);
            using var stream = new StreamReader(file, Encoding.UTF8);
            var storage = stream.ReadToEnd();
            if (string.IsNullOrEmpty(storage))
            {
                return new DataContext();
            }
            return JsonSerializer.Deserialize<DataContext>(storage);
        }
    }
}