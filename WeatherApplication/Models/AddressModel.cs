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

      public AddressModel()
      {
         SetConfigStrings();
      }

      public string BuildAddressString()
      {
         US_State state = new US_State();
         string selState = state.GetStateCode(StateCode);
         StringBuilder address = new StringBuilder();
         address.Append(addressString); address.Append(StructureNumber);
         address.Append(delimeterPlusSign); address.Append(StreetName);
         address.Append(cityString); address.Append(City);
         address.Append(stateString); address.Append(selState);
         address.Append(suffixString);
         address.Replace(' ', '+');

         return address.ToString();
      }
   
      private void SetConfigStrings()
      {
         //TODO:  Pull these from appsettings or some other configuration file
         //TODO:  Possibly implement and Interface
         delimeterPlusSign = "+";
         addressString = "address?street=";
         cityString = "&city=";
         stateString = "&state=";
         suffixString = "&benchmark=9&format=json";
      }
   }
}
