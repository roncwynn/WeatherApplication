using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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

      private string addressString, cityString, stateString;
      private string delimeterPlusSign;
      private string suffixString;

      public string BuildAddressString(string SelectedStateCode)
      {
         SetConfigStrings();
         StringBuilder address = new StringBuilder();
         address.Append(addressString); address.Append(StructureNumber);
         address.Append(delimeterPlusSign); address.Append(StreetName);
         address.Append(cityString); address.Append(City);
         address.Append(stateString); address.Append(SelectedStateCode);
         address.Append(suffixString);
         address.Replace(' ', '+');

         return address.ToString();
      }
   
      private void SetConfigStrings()
      {
         //delimeterPlusSign = _config.GetValue<string>("delimeterPlusSign");
         delimeterPlusSign = "+";
         //addressString = _config.GetValue<string>("addressString");
         addressString = "address?street=";
         //cityString = _config.GetValue<string>("cityString");
         cityString = "&city=";
         //stateString = _config.GetValue<string>("stateString");
         stateString = "&state=";
         //suffixString = _config.GetValue<string>("suffixString");
         suffixString = "&benchmark=9&format=json";
         //pointsString = _config.GetValue<string>("pointsString");
      }


   }
}
