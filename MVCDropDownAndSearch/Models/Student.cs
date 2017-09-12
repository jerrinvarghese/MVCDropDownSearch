using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDropDownAndSearch.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        // public string department { get; set; }
        public IEnumerable<SelectListItem> department { get; set; }
    }
}