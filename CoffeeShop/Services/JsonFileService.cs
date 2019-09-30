using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Hosting;

namespace CoffeeShop.Services
{
    public class JsonFileService
    {
        public JsonFileService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string JsonFilePath
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Coffee.json"); }
        }
        public IEnumerable<Coffee> GetCoffees()
        {
            using (var jsonFileReader = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Coffee[]>(jsonFileReader.ReadToEnd());
            }
        }
        
    }
}
