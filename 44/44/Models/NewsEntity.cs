using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _44.Models
{
    public class NewsEntity
    {
        public string Text { get; set; }
        public DataTime PublishDate { get; set; }
    }
}