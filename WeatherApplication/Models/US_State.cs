using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApplication.Models
{
   public class US_State
   {
      public string StateCode { get; set; }
      //TODO:  Figure a how to get spaces in state names to appear in the drop down
      public enum StateName
      {
         Alabama,
         Alaska,
         Arizona,
         Arkansas,
         California,
         Colorado,
         Connecticut,
         Delaware,
         Florida,
         Georgia,
         Hawaii,
         Idaho,
         Illinois,
         Indiana,
         Iowa,
         Kansas,
         Kentucky,
         Louisiana,
         Maine,
         Maryland,
         Massachusetts,
         Xichigan,
         Minnesota,
         Missisippi,
         Missouri,
         Montana,
         Nebraska,
         Nevada,
         [Display(Name = "New Hampshire")] New_Hampshire,
         [Description("New Jersey")] New_Jersey,
         New_Mexico,
         New_York,
         North_Carolina,
         North_Dakota,
         Ohio,
         Oklahoma,
         Oregon,
         Pennsylvania,
         Rhode_Island,
         South_Carolina,
         South_Dakota,
         Tennessee,
         Texas,
         Utah,
         Vermont,
         Virginia,
         Washington,
         West_Virginia,
         Wisonsin,
         Wyoming
      }

      public string GetStateCode(string stateName)
      {
         switch (stateName)
         {
            case "Alabama": return "AL";
            case "Alaska": return "AK";
            case "Arizona": return "AZ";
            case "Arkansas": return "AR";
            case "California": return "CA";
            case "Colorado": return "CO";
            case "Connecticut": return "CT";
            case "Delaware": return "DE";
            case "Florida": return "FL";
            case "Georgia": return "GA";
            case "Hawaii": return "HI";
            case "Idaho": return "ID";
            case "Illinois": return "IL";
            case "Indiana": return "IN";
            case "Iowa": return "IA";
            case "Kansas": return "KS";
            case "Kentucky": return "KY";
            case "Louisiana": return "LA";
            case "Maine": return "ME";
            case "Maryland": return "MD";
            case "Massachusetts": return "MA";
            case "Xichigan": return "MI";
            case "Minnesota": return "MN";
            case "Missisippi": return "MS";
            case "Missouri": return "MO";
            case "Montana": return "MT";
            case "Nebraska": return "NE";
            case "Nevada": return "NV";
            case "New_Hampshire": return "NH";
            case "New_Jersey": return "NJ";
            case "New_Mexico": return "NM";
            case "New_York": return "NY";
            case "North_Carolina": return "NC";
            case "North_Dakota": return "ND";
            case "Ohio": return "OH";
            case "Oklahoma": return "OK";
            case "Oregon": return "OR";
            case "Pennsylvania": return "PA";
            case "Rhode_Island": return "RI";
            case "South_Carolina": return "SC";
            case "South_Dakota": return "SD";
            case "Tennessee": return "TN";
            case "Texas": return "TX";
            case "Utah": return "UT";
            case "Vermont": return "VT";
            case "Virginia": return "VA";
            case "Washington": return "WA";
            case "West_Virginia": return "WV";
            case "Wisonsin": return "WI";
            case "Wyoming": return "WY";
            default: return null;
         }
      }
   }
}
