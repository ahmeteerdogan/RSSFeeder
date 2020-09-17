using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cerezlik.Data.Adapter;
using Cerezlik.Data.DTO;
using Cerezlik.Data.DTO.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cerezlik.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        ISysDataAdapter da = null;
        public DataController()
        {
            da = new SysDataAdapter();
        }

        [HttpGet("GetAllArticle")]
        public IEnumerable<Article> GetAllArticle()
        {
            var a = da.GetAllArticle();
            return a;
        }

        [HttpGet("GetArticleListByCategory")]
        public IEnumerable<Article> GetArticleListByCategory(CategoryEnums category)
        {
            var a = da.GetArticleListByCategory(category);
            return a;
        }

        [HttpGet("GetArticleById")]
        public Article GetArticleById(Guid Id)
        {
            var a = da.GetArticleById(Id);
            return a;
        }
    }
}
