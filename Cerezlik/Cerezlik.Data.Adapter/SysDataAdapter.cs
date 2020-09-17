using Cerezlik.Data.DTO;
using Cerezlik.Data.DTO.Enum;
using NPoco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cerezlik.Data.Adapter
{
    public class SysDataAdapter : BaseDataAdapter, ISysDataAdapter
    {
        public List<Article> GetAllArticle()
        {
            try
            {
                Sql cmd = new Sql(@"select * from Article a order by a.PublishedDate desc");
                var k = Db.Fetch<Article>(cmd);
                return k;
            }
            catch (Exception e)
            {
                return null;
                //TODO:
            }
        }

        public Article GetArticleById(Guid Id)
        {
            try
            {
                Sql cmd = new Sql(@"select * from Article a where a.Oid=@0", Id.ToString());
                var k = Db.Fetch<Article>(cmd);
                if (k != null)
                {
                    return k[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<Article> GetArticleListByCategory(CategoryEnums e)
        {
            try
            {
                Sql cmd = new Sql(@"select top 250 * from Article a where a.Category = @0
                                    order by a.PublishedDate desc", e);
                var k = Db.Fetch<Article>(cmd);
                return k;
            }
            catch (Exception ex)
            {
                return null;
                //TODO:
            }
        }


    }
}
