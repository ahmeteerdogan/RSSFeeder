using Feeder.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feeder.Data.Adapter
{
    public interface ISysDataAdapter
    {
        //List<Technology> ListTechnology();
        void SaveDataList(List<Article> l);
    }
}
