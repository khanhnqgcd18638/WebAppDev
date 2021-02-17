using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDeve.Models
{
    public class CategoryCourseModel
    {
        public Course Course { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}