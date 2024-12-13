using MainApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.Services
{
    public class FileService
    {
        private readonly string _filePath;

        public FileService(string filePath)
        {
            _filePath = filePath;
        }

        public List<KontaktModel> LaddaKontakter()
        {
            if (!File.Exists(_filePath))
                return new List<KontaktModel>();

            var jsonData = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<KontaktModel>>(jsonData) ?? new List<KontaktModel>();
        }

        public void SaveKontakter(List<KontaktModel> kontakter)
        {
            var jsonData = JsonSerializer.Serialize(kontakter, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, jsonData);
        }
    }
}

