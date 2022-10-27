using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgSrc { get; set; }
        public string ImgAlt { get; set; }
        public string Description { get; set; }
    }
}
