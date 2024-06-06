﻿using Microsoft.AspNetCore.Hosting;
using PortalAboutEverything.Data.Model;

namespace PortalAboutEverything.Services
{
    public class PathHelper
    {
        private IWebHostEnvironment _webHostEnvironment;

        public PathHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string GetPathToGameCover(int gameId)
        {
            var fileName = $"cover-{gameId}.jpg";
            return GetPathByFolder("images\\Game", fileName);
        }

        public bool IsGameCoverExist(int id)
        {
            var path = GetPathToGameCover(id);
            return File.Exists(path);
        }

        private string GetPathByFolder(string pathToFolder, string fileName)
        {
            var path = Path.Combine(_webHostEnvironment.WebRootPath, pathToFolder, fileName);
            return path;
        }
    }
}