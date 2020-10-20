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

      private string gridpointsString;
      private string delimeterSlash, delimeterComma;
      private string forecastString;

      public ForecastsPointModel()
      {
         SetConfigStrings();
      }

      public string BuildForecastString()
      {
         StringBuilder forecast = new StringBuilder();
         forecast.Append(gridpointsString);
         //forecast.Append(someForeCastpoint.properties.gridId.ToString());
         forecast.Append(properties.gridId.ToString());
         forecast.Append(delimeterSlash);
         forecast.Append(properties.gridX.ToString());
         forecast.Append(delimeterComma);
         forecast.Append(properties.gridY.ToString());
         forecast.Append(forecastString);

         return forecast.ToString();
      }

      private void SetConfigStrings()
      {
         //TODO:  Pull these from appsettings or some other configuration file
         //TODO:  Possibly implement and Interface
         delimeterComma = ",";
         delimeterSlash = "/";
         gridpointsString = "gridpoints/";
         forecastString = "/forecast";
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
