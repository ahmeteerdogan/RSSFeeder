using CerezlikWeb.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerezlikWeb.App
{
    public static class Cache
    {
        public static List<Article> ListArticle { get; set; }
        public static List<Article> JournalList { get; set; }
        public static List<Article> FunList { get; set; }
        public static List<Article> JobList { get; set; }
        public static List<Article> TravelList { get; set; }
        public static List<Article> LifeList { get; set; }
        public static List<Article> SporList { get; set; }
        public static List<Article> MotorsportList { get; set; }
    }
}
