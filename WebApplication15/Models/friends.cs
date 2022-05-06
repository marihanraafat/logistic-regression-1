using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class friends
    {
        public int id { get; set; }
        
        public string name { get; set; }
        public string imagePpath{ get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string imagePpath2 { get; set; }
        public int mobile { get; set; }
        public posts post { get; set; }

    }
}