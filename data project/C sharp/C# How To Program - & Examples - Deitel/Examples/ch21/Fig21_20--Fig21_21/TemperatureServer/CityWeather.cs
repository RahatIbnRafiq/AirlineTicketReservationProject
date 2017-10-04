// Fig. 21.21: CityWeather.cs
// Class representing the weather information for one city.

using System;

namespace TemperatureWebService
{
   public class CityWeather
   {
      private string cityName;
      private string temperature;
      private string description;
   
      public CityWeather(
         string city, string information, string degrees )
      {
         cityName = city;
         description = information;
         temperature = degrees;
      }

      // city name
      public string CityName
      {
         get
         {
            return cityName;
         }
      }

      // city temperature
      public string Temperature
      {
         get
         {
            return temperature;
         }
      }

      // forecast description
      public string Description
      {
         get
         {
            return description;
         }
      }

   } // end class CityWeather
} // end namespace TemperatureWebService

/*
 **************************************************************************
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/