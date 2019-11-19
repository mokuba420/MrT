using System;
using System.ComponentModel.DataAnnotations;

namespace MRTshirtAPi.Api.Modles
{
    public class TShirttable
    {

        public int ID { get; set; }

        [Required]
       
        public string Name { get; set; }

        [Required]
        public string Size { get; set; }
          
        [Required]
        public string ShippingAddress { get; set; }
        public bool Done { get; set; }
    }
}
