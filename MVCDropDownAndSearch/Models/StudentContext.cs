using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDropDownAndSearch.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("StudentConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
    }

}