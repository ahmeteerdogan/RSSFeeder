using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CerezlikWeb.App.Models;
using CerezlikWeb.App.API;

namespace CerezlikWeb.App.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int Id)
        {
            List<Article> l;
            switch (Id)
            {
                case 1:
                    l = APIService.GetArticleListByCategory(CategoryEnums.Journal).Result;
                    ViewBag.CategoryName = "Gündem";
                    return View(l);
                case 2:
                    l = APIService.GetArticleListByCategory(CategoryEnums.GameAndGeek).Result;
                    ViewBag.CategoryName = "Eğlence";
                    return View(l);
                case 3:
                    l = APIService.GetArticleListByCategory(CategoryEnums.JobAndFinance).Result;
                    ViewBag.CategoryName = "İş";
                    return View(l);
                case 4:
                    l = APIService.GetArticleListByCategory(CategoryEnums.Travel).Result;
                    ViewBag.CategoryName = "Gezi";
                    return View(l);
                case 5:
                    l = APIService.GetArticleListByCategory(CategoryEnums.Life).Result;
                    ViewBag.CategoryName = "Yaşam";
                    return View(l);
                case 6:
                    l = APIService.GetArticleListByCategory(CategoryEnums.Sport).Result;
                    ViewBag.CategoryName = "Spor";
                    return View(l);
                case 7:
                    l = APIService.GetArticleListByCategory(CategoryEnums.Motorsport).Result;
                    ViewBag.CategoryName = "Otomobil";
                    return View(l);
                case 8:
                    l = APIService.GetArticleListByCategory(CategoryEnums.Technology).Result;
                    ViewBag.CategoryName = "Teknoloji";
                    return View(l);
                case 9:
                    l = APIService.GetArticleListByCategory(CategoryEnums.Science).Result;
                    ViewBag.CategoryName = "Bilim";
                    return View(l);

                default:
                    break;
            }
            return View(null);
        }
    }
}
