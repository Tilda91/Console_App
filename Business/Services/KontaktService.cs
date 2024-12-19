using Business.Services;
using System;
using System.Collections.Generic;

namespace MainApp
{
    public class KontaktService
    {
        private readonly FileService _fileService;

        public KontaktService(string filePath)
        {
            _fileService = new FileService(filePath);
        }
        public List<KontaktModel> LaddaKontakter() => _fileService.LaddaKontakter();
        public void SparaKontakter(List<KontaktModel> kontakter) => _fileService.SaveKontakter(kontakter);
    }
}


