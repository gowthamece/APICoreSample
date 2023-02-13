using HotelApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[HttpGet(Name = "GetValue")]
        //public string GetValues()
        //{
        //    return "Sachin";
        //}

        [HttpGet]
        public ActionResult HotelList()
        {
            var hotel = new List<Hotel>();
            hotel.Add(new Hotel{ Id=1, Name="A2B"});
            hotel.Add(new Hotel{ Id = 1, Name = "A2B" });
            return Ok(hotel);
        }

        [HttpGet("hotelId",Name ="GetHotelById")]
        public ActionResult HotelList(int id)
        {
            var hotel = new List<Hotel>();
            hotel.Add(new Hotel { Id = 1, Name = "A2B" });
            hotel.Add(new Hotel { Id = 2, Name = "Gowtham" });
            return Ok(hotel.Where(e=>e.Id==id));
        }
    }
}
