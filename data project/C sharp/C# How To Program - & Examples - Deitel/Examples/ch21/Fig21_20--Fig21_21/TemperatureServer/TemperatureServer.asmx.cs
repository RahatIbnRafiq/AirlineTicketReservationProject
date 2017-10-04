// Fig. 21.20: TemperatureServer.asmx.cs
// TemperatureServer Web Service that extracts weather 
// information from a Web page.

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Net;

namespace TemperatureWebService
{
   [ WebService( Namespace = "http://www.deitel.com/csphtp1/ch21/",
        Description = "A Web service that provides information " +
        "from the National Weather Service." ) ]
   public class TemperatureServer : 
      System.Web.Services.WebService
   {
      public TemperatureServer()
      {
         InitializeComponent();
      }
      
		#region Component Designer generated code
		
		//Required by the Web Services Designer 
		private IContainer components = null;
				
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

      [ WebMethod( EnableSession = true, Description =
           "Method to read information from the weather service." ) ]
      public void UpdateWeatherConditions()
      {
         // create WebClient to get access to Web page
         WebClient myClient = new WebClient();         
         ArrayList cityList = new ArrayList();

         // get StreamReader for response so we can read page
         StreamReader input = new StreamReader(
            myClient.OpenRead(
            "http://iwin.nws.noaa.gov/iwin/us/" +
            "traveler.html" ) );

         string separator = "TAV12";

         // locate first horizontal line on Web page
         while ( !input.ReadLine().StartsWith( 
            separator ) ) ; // do nothing

         // day format and night format
         string dayFormat =
            "CITY            WEA     HI/LO   WEA     " + 
            "HI/LO";
         string nightFormat =
            "CITY            WEA     LO/HI   WEA     " + 
            "LO/HI";
         string inputLine = "";

         // locate header that begins weather information
         do
         {
            inputLine = input.ReadLine();
         } while ( !inputLine.Equals( dayFormat ) && 
            !inputLine.Equals( nightFormat ) );

         // get first city's data
         inputLine = input.ReadLine(); 

         while ( inputLine.Length > 28 )
         {
            // create CityWeather object for city
            CityWeather weather = new CityWeather(
               inputLine.Substring( 0, 16 ),
               inputLine.Substring( 16, 7 ),
               inputLine.Substring( 23, 7 ) );

            // add to List
            cityList.Add( weather );   

            // get next city's data
            inputLine = input.ReadLine(); 
         }

         // close connection to NWS server
         input.Close();    

         // add city list to user session
         Session.Add( "cityList", cityList );

      } // end UpdateWeatherConditions

      // gets all city names
      [ WebMethod( EnableSession = true, Description = 
           "Method to retrieve a list of cities." ) ]
      public string[] Cities()
      {
         ArrayList cityList = ( ArrayList ) Session[ "cityList" ];
         string[] cities= new string[ cityList.Count ];

         // retrieve names for cities
         for ( int i = 0; i < cityList.Count; i++ )
         {
            CityWeather weather = ( CityWeather ) cityList[ i ];

            cities[ i ] = weather.CityName;
         }

         return cities;

      } // end method Cities

      // gets all city descriptions
      [ WebMethod( EnableSession = true, Description = "Method" +
           " to retrieve weather descriptions for a " +
           "list of cities." )]
      public string[] Descriptions()
      {
         ArrayList cityList = ( ArrayList ) Session[ "cityList" ];
         string[] descriptions= new string[ cityList.Count ];

         // retrieve weather descriptions for all cities
         for ( int i = 0; i < cityList.Count; i++ )
         {
            CityWeather weather = ( CityWeather )cityList[ i ];

            descriptions[ i ] = weather.Description;
         }      

         return descriptions;

      } // end method Descriptions

      // obtains each city temperature
      [ WebMethod( EnableSession = true, Description = "Method " +
           "to retrieve the temperature for a list of cities." ) ]
      public string[] Temperatures()
      {
         ArrayList cityList = ( ArrayList ) Session[ "cityList" ];
         string[] temperatures= new string[ cityList.Count ];

         // retrieve temperatures for all cities
         for ( int i = 0; i < cityList.Count; i++ )
         {
            CityWeather weather = ( CityWeather )cityList[ i ];
            temperatures[ i ] = weather.Temperature;
         }
   
         return temperatures;

      } // end method Temperatures

   } // end class TemperatureServer

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
