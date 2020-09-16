using Feeder.Data.Adapter;
using Feeder.Data.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feeder.Service
{
    public class Service
    {
        ISysDataAdapter da = null;
        public Service()
        {
            da = new SysDataAdapter();
        }

        public void SaveDataList(List<Article> l)
        {
            da.SaveDataList(l);
        }
    }
}
