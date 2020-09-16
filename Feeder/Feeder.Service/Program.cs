using Feeder.Data.Adapter;
using Feeder.Data.DTO;
using Feeder.Data.DTO.Enum;
using Feeder.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace Feeder.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();

            //15dakika da 1 kez çek
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1800000;
            timer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) => Init();
            timer.Start();

            Console.ReadLine();
        }

        private static void Init()
        {
            Category category = ReadCategory();
            foreach (CategoryEnums c in (CategoryEnums[])Enum.GetValues(typeof(CategoryEnums)))
            {
                List<string> list = (List<string>)category.GetType().GetProperty(c.ToString()).GetValue(category, null);
                List<Article> dataList = GetAndSaveData(list, c).OrderByDescending(x => x.PublishedDate).ToList();
                Console.WriteLine(c.ToString() + "--->" + dataList.Count().ToString());
            }
        }

        private static Category ReadCategory()
        {
            Category category;
            string startupPath = System.IO.Directory.GetCurrentDirectory() + "\\Cat.json";

            using (StreamReader r = new StreamReader(startupPath))
            {
                string json = r.ReadToEnd();
                category = JsonConvert.DeserializeObject<Category>(json);
            }

            return category;
        }

        private static List<Article> GetAndSaveData(List<string> rssList, CategoryEnums cat)
        {
            List<Article> dataList = new List<Article>();
            foreach (var url in rssList)
            {
                FillRSSData(dataList, url, cat);
            }

            Service s = new Service();
            s.SaveDataList(dataList);
            return dataList;
        }

        private static void FillRSSData(List<Article> dataList, string url, CategoryEnums cat)
        {
            try
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                foreach (SyndicationItem item in feed.Items)
                {
                    Article d = new Article();
                    d.Oid = Guid.NewGuid();
                    d.Header = item.Title.Text;
                    d.Content = item.Summary.Text;
                    d.PublishedDate = item.PublishDate.DateTime;
                    d.Url = item.Id;
                    d.Generator = feed.Title.Text;
                    d.Category = cat;
                    dataList.Add(d);

                    string link = MakeLink(d.Content);

                    if (!string.IsNullOrEmpty(link) && (link.EndsWith(".png") || link.EndsWith(".jpg") || link.EndsWith(".jpeg")))
                    {
                        d.Photo = link;
                    }

                    if (string.IsNullOrEmpty(d.Photo))
                    {
                        foreach (SyndicationElementExtension extension in item.ElementExtensions)
                        {
                            XElement ele = extension.GetObject<XElement>();
                            if (!string.IsNullOrEmpty(ele.ToString()))
                            {
                                link = MakeLink(ele.ToString());
                                if (!string.IsNullOrEmpty(link) && (link.EndsWith(".png") || link.EndsWith(".jpg") || link.EndsWith(".jpeg")))
                                {
                                    d.Photo = link;
                                    break;
                                }
                            }
                        }
                    }

                    if (item.Content != null)
                    {
                        TextSyndicationContent tsc = (TextSyndicationContent)item.Content;
                        if (!string.IsNullOrEmpty(tsc.Text) && string.IsNullOrEmpty(d.Photo))
                        {
                            link = MakeLink(tsc.Text);
                            d.Photo = link;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error URL---->" + url);
            }

        }

        public static string MakeLink(string txt)
        {
            var linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (Match m in linkParser.Matches(txt))
            {
                if (m.Value.Contains(".jpg") || m.Value.Contains(".jpeg") || m.Value.Contains(".png"))
                {
                    string b = "";
                    if (m.Value.Contains(".jpg"))
                    {
                        b = m.Value.Substring(0, m.Value.IndexOf(".jpg") + 4);
                    }
                    if (m.Value.Contains(".jpeg"))
                    {
                        b = m.Value.Substring(0, m.Value.IndexOf(".jpeg") + 5);
                    }
                    if (m.Value.Contains(".png"))
                    {
                        b = m.Value.Substring(0, m.Value.IndexOf(".png") + 4);
                    }

                    txt = b;

                    return txt;
                }
            }
            return txt;
        }
    }
}
