using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _44.Models
{
    public class BlogEntity
    {
        public string Article { get; set; }
        public string Text { get; set; }
        public List<string> Tags { get; set; }
        public string ImagePath { get; set; }
    }
}