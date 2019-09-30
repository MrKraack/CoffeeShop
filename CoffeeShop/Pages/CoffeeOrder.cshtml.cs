using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using CoffeeShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CoffeeShop.Pages
{
    public class CoffeeOrderModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileService jsonFileService;
        public IEnumerable<Coffee> Coffees { get; private set; }

        public CoffeeOrderModel(ILogger<IndexModel> logger, JsonFileService fileService)
        {
            _logger = logger;
            jsonFileService = fileService;
        }

        public void OnGet()
        {
            Coffees = jsonFileService.GetCoffees();

        }

    }
}