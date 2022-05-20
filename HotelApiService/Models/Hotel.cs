using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApiService.Models
{
    public class Hotel
    {
        
        public int HotelId { get; set; }
       
        public string HotelName { get; set; }
       
        public string HotelAddress { get; set; }
        
        public string City { get; set; }
       
        public string State { get; set; }
        
        public string PinCode { get; set; }
       
        public string IsActive { get; set; }

    }
}
