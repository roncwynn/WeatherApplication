using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Models
{
   public class GeoLocationModel
   {
      public Result result { get; set; }

      private string pointsString;
      private string delimeterComma;

      public GeoLocationModel()
      {
         SetConfigStrings();
      }

      public string BuildForcastPointsString()
      {
         //For this version of the solution we assume that the first returned result is the desired forcast location
         //Therefore hardcoding [0] for the result.addressMatches is appropriate
         //In a future version we may handle allowing the use to select a result
         StringBuilder coordinatesString = new StringBuilder();
         coordinatesString.Clear();
         coordinatesString.Append(pointsString);
         coordinatesString.Append(result.addressMatches[0].coordinates.y.ToString());
         coordinatesString.Append(delimeterComma);
         coordinatesString.Append(result.addressMatches[0].coordinates.x.ToString());

         return coordinatesString.ToString();
      }
      private void SetConfigStrings()
      {
         //TODO:  Pull these from appsettings or some other configuration file
         //TODO:  Possibly implement and Interface
         delimeterComma = ",";
         pointsString = "points/";
      }

   }

   public class Result
   {
      public Input input { get; set; }
      public Addressmatch[] addressMatches { get; set; }
   }

   public class Input
   {
      public Benchmark benchmark { get; set; }
      public Address address { get; set; }
   }

   public class Benchmark
   {
      public string id { get; set; }
      public string benchmarkName { get; set; }
      public string benchmarkDescription { get; set; }
      public bool isDefault { get; set; }
   }

   public class Address
   {
      public string street { get; set; }
      public string city { get; set; }
      public string state { get; set; }
      public string zip { get; set; }
   }

   public class Addressmatch
   {
      public string matchedAddress { get; set; }
      public Coordinates coordinates { get; set; }
      public Tigerline tigerLine { get; set; }
      public Addresscomponents addressComponents { get; set; }
   }

   public class Coordinates
   {
      public float x { get; set; }
      public float y { get; set; }
   }

   public class Tigerline
   {
      public string tigerLineId { get; set; }
      public string side { get; set; }
   }

   public class Addresscomponents
   {
      public string fromAddress { get; set; }
      public string toAddress { get; set; }
      public string preQualifier { get; set; }
      public string preDirection { get; set; }
      public string preType { get; set; }
      public string streetName { get; set; }
      public string suffixType { get; set; }
      public string suffixDirection { get; set; }
      public string suffixQualifier { get; set; }
      public string city { get; set; }
      public string state { get; set; }
      public string zip { get; set; }
   }
}
