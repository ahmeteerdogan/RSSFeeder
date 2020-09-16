using Feeder.Data.DTO;
using Microsoft.Extensions.Logging;
using NPoco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feeder.Data.Adapter
{
    public class SysDataAdapter : BaseDataAdapter, ISysDataAdapter
    {
        public void SaveDataList(List<Article> l)
        {
            try
            {
                foreach (var t in l)
                {
                    if (t.PublishedDate.Year == 0001)
                        t.PublishedDate = DateTime.Now;

                    Sql cmd = new Sql(@"select * from Article a
                where a.Content= @0", t.Content);

                    var k = Db.Fetch<Article>(cmd);

                    if (k.Count == 0 && t.Photo != null)
                    {
                        Db.Insert<Article>(t);
                    }
                }
            }
            catch (Exception e)
            {
                //TODO:
            }
        }

        //public List<Technology> ListTechnology()
        //{
        //    Sql cmd = new Sql(@"select * from Technology");
        //    var list = Db.Fetch<Technology>(cmd);
        //    return list;
        //}
    }
}
