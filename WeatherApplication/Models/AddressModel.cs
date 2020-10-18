using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApplication.Models
{
   public class AddressModel
   {
      [Required (ErrorMessage = "Structure Number is required.")]
      public string  StructureNumber { get; set; }

      [Required(ErrorMessage = "Street Name is required.")]
      public string StreetName { get; set; }

      [Required(ErrorMessage = "City is required.")]
      public string City { get; set; }

      [Required(ErrorMessage = "State is required.")]
      public string StateCode { get; set; }
   }
}
