using Feeder.Data.DTO.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feeder.Data.DTO
{
    public class Article
    {
        public Guid Oid { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Photo { get; set; }
        public string Generator { get; set; }
        public CategoryEnums Category { get; set; }
    }
}
