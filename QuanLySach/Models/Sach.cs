using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySach.Models
{
    public class Sach
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String AuthorName { get; set; }
        public decimal Price { get; set; }
    }
}