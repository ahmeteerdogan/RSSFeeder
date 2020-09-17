using Cerezlik.Data.DTO;
using Cerezlik.Data.DTO.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cerezlik.Data.Adapter
{
    public interface ISysDataAdapter
    {
        //List<Technology> ListTechnology();
        List<Article> GetAllArticle();

        List<Article> GetArticleListByCategory(CategoryEnums e);

        Article GetArticleById(Guid Id);
    }
}
