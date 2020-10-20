using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Models
{
   public class ForecastsPointModel
   {
      public object[] context { get; set; }
      public string id { get; set; }
      public string type { get; set; }
      public ForecastPointProperties properties { get; set; }

      private string pointsString;
      private string delimeterComma;

      public ForecastsPointModel()
      {
         //SetConfigStrings();
      }
  
   }

   public class ForecastPointProperties
   {
      public string gridId { get; set; }
      public int gridX { get; set; }
      public int gridY { get; set; }
      public string forecast { get; set; }
   }
}
