using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach { Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh xanh xanh", AuthorName = "Nguyễn Nhật Ánh", Price = 1, Content = "Truyện kể về tuổi thơ.........."},
            new Sach { Id = 2, Title = "Pro ASPNET MVC5", AuthorName = "Adam Freeman", Price = 3.75M, Content = "The latest evolution of Microsoft's"},
            
        };
        //Get: api/sach
        [Route("api/sach")]
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        //Get: api/sach/1
        [Route("api/sach/{id:int}")]
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
        //Get: api/sach/b
        [Route("api/sach/{name}")]
        public IHttpActionResult GetProductByName(string name)
        {
            var sach = sachs.FirstOrDefault(p => p.Title == name);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
