﻿using KenkataWebshop.Data;
using Microsoft.AspNetCore.Mvc;

namespace KenkataWebshop.WebClient.Controllers
{
 
    public class CategoryController : Controller
    {
        private readonly HttpClient _httpClient;

        public CategoryController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [Route("Category")]
        public async Task <IActionResult> Index()
        {

            var categories = await _httpClient.GetFromJsonAsync<List<CategoryDto>>("https://localhost:7009/swagger/index.html");
            

            //var categoryViewModels = new List<CategoryViewModel>
            //{
            //    new CategoryViewModel{Category = "Men"},
            //    new CategoryViewModel{Category = "Women"},
            //    new CategoryViewModel{Category = "Kids"},
            //    new CategoryViewModel{Category = "Shoes"},
            //    new CategoryViewModel{Category = "Hats"},
            //    new CategoryViewModel{Category = "Watches"}
            //};

            return View();
        }
    }
}

