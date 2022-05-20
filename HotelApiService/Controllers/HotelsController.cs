using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiService.Models;

namespace HotelApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        public IActionResult Get()
        {
            var roomList = new List<Hotel>() {
                new Hotel(){HotelId=100,  HotelName="ABC",  HotelAddress="Pippari Chichwad, Pune", City="Pune", State="Maharashtra", PinCode="411000", IsActive="Available" },
                 new Hotel(){HotelId=101,  HotelName="PQR",  HotelAddress="Mumbai Bandra", City="Mumbai", State="Maharashtra", PinCode="411222", IsActive="Available" },
                  new Hotel(){HotelId=100,  HotelName="XYZ",  HotelAddress="Nampalli Hydrabad", City="Hydrabad", State="Maharashtra", PinCode="411333", IsActive="Available" }

            };

            return Ok(roomList);
        }
    }
}
