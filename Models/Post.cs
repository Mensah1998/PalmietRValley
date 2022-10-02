using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PalmietRValley.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public Author Author { get; set; }
        public string Tags { get; set; }

        public DateTime CreateTime { get; set; }

    }

}