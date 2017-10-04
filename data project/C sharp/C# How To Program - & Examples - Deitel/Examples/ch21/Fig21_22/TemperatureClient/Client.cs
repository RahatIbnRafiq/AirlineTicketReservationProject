// Fig. 21.22: Client.cs
// Class that displays weather information that it receives
// from a Web service.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;

namespace TemperatureClient
{
   public class Client : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.Label label14;
      private System.Windows.Forms.Label label15;
      private System.Windows.Forms.Label label16;
      private System.Windows.Forms.Label label17;
      private System.Windows.Forms.Label label18;
      private System.Windows.Forms.Label label19;
      private System.Windows.Forms.Label label20;
      private System.Windows.Forms.Label label21;
      private System.Windows.Forms.Label label22;
      private System.Windows.Forms.Label label23;
      private System.Windows.Forms.Label label24;
      private System.Windows.Forms.Label label25;
      private System.Windows.Forms.Label label26;
      private System.Windows.Forms.Label label27;
      private System.Windows.Forms.Label label28;
      private System.Windows.Forms.Label label29;
      private System.Windows.Forms.Label label30;
      private System.Windows.Forms.Label label31;
      private System.Windows.Forms.Label label32;
      private System.Windows.Forms.Label label33;
      private System.Windows.Forms.Label label34;
      private System.Windows.Forms.Label label36;
      private System.Windows.Forms.Label label35;

      private System.ComponentModel.Container components = 
         null;

      public Client()
      {
         InitializeComponent();

         localhost.TemperatureServer client = 
            new localhost.TemperatureServer();
         client.CookieContainer = new CookieContainer();
         client.UpdateWeatherConditions();

         string[] cities = client.Cities();
         string[] descriptions = client.Descriptions();
         string[] temperatures = client.Temperatures();

         label35.BackgroundImage = new Bitmap( 
            "images/header.png" );
         label36.BackgroundImage = new Bitmap( 
            "images/header.png" );
        
         // create Hashtable and populate it with every label
         Hashtable cityLabels = new Hashtable();
         cityLabels.Add( 1, label1 );
         cityLabels.Add( 2, label2 );
         cityLabels.Add( 3, label3 );
         cityLabels.Add( 4, label4 );
         cityLabels.Add( 5, label5 );
         cityLabels.Add( 6, label6 );
         cityLabels.Add( 7, label7 );
         cityLabels.Add( 8, label8 );
         cityLabels.Add( 9, label9 );
         cityLabels.Add( 10, label10 );
         cityLabels.Add( 11, label11 );
         cityLabels.Add( 12, label12 );
         cityLabels.Add( 13, label13 );
         cityLabels.Add( 14, label14 );
         cityLabels.Add( 15, label15 );
         cityLabels.Add( 16, label16 );
         cityLabels.Add( 17, label17 );
         cityLabels.Add( 18, label18 );
         cityLabels.Add( 19, label19 );
         cityLabels.Add( 20, label20 );
         cityLabels.Add( 21, label21 );
         cityLabels.Add( 22, label22 );
         cityLabels.Add( 23, label23 );
         cityLabels.Add( 24, label24 );
         cityLabels.Add( 25, label25 );
         cityLabels.Add( 26, label26 );
         cityLabels.Add( 27, label27 );
         cityLabels.Add( 28, label28 );
         cityLabels.Add( 29, label29 );
         cityLabels.Add( 30, label30 );
         cityLabels.Add( 31, label31 );
         cityLabels.Add( 32, label32 );
         cityLabels.Add( 33, label33 );
         cityLabels.Add( 34, label34 );

         // create Hashtable and populate with 
         // all weather conditions
         Hashtable weather = new Hashtable();
         weather.Add( "SUNNY", "sunny" );
         weather.Add( "PTCLDY", "pcloudy" );
         weather.Add( "CLOUDY", "mcloudy" );
         weather.Add( "MOCLDY", "mcloudy" );
         weather.Add( "TSTRMS", "rain" );
         weather.Add( "RAIN", "rain" );
         weather.Add( "SNOW", "snow" );
         weather.Add( "VRYHOT", "vryhot" );
         weather.Add( "FAIR", "fair" );
         weather.Add( "RNSNOW", "rnsnow" );
         weather.Add( "SHWRS", "showers" );
         weather.Add( "WINDY", "windy" );
         weather.Add( "NOINFO", "noinfo" );
         weather.Add( "MISG", "noinfo" );
         weather.Add( "DRZL", "rain" );
         weather.Add( "HAZE", "noinfo" );
         weather.Add( "SMOKE", "mcloudy" );
         weather.Add( "SNOWSHWRS", "snow" );
         weather.Add( "FLRRYS", "snow" );

         Bitmap background = new Bitmap( "images/back.png" );
         Font font = new Font( "Courier New", 8, 
            FontStyle.Bold );

         // for every city
         for ( int i = 0; i < cities.Length; i++ )
         {
            // use Hashtable cityLabels to find the next Label
            Label currentCity = ( Label )cityLabels[ i + 1 ];

            // set current Label's image to image 
            // corresponding to the city's weather condition - 
            // find correct image name in Hashtable weather
            currentCity.Image = new Bitmap( "images/" + 
               weather[ descriptions[ i ].Trim() ] + ".png" );

            // set background image, font and forecolor 
            // of Label
            currentCity.BackgroundImage = background;
            currentCity.Font = font;
            currentCity.ForeColor = Color.White;

            // set label's text to city name
            currentCity.Text = "\r\n" + cities[ i ] + " " + 
               temperatures[ i ];
         }

      } // end of constructor

		#region Windows Form Designer generated code      
      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if(components != null)
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.label35 = new System.Windows.Forms.Label();
         this.label28 = new System.Windows.Forms.Label();
         this.label29 = new System.Windows.Forms.Label();
         this.label26 = new System.Windows.Forms.Label();
         this.label27 = new System.Windows.Forms.Label();
         this.label24 = new System.Windows.Forms.Label();
         this.label25 = new System.Windows.Forms.Label();
         this.label22 = new System.Windows.Forms.Label();
         this.label23 = new System.Windows.Forms.Label();
         this.label20 = new System.Windows.Forms.Label();
         this.label21 = new System.Windows.Forms.Label();
         this.label19 = new System.Windows.Forms.Label();
         this.label18 = new System.Windows.Forms.Label();
         this.label15 = new System.Windows.Forms.Label();
         this.label14 = new System.Windows.Forms.Label();
         this.label17 = new System.Windows.Forms.Label();
         this.label16 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label30 = new System.Windows.Forms.Label();
         this.label36 = new System.Windows.Forms.Label();
         this.label12 = new System.Windows.Forms.Label();
         this.label34 = new System.Windows.Forms.Label();
         this.label33 = new System.Windows.Forms.Label();
         this.label32 = new System.Windows.Forms.Label();
         this.label31 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // label8
         // 
         this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label8.Location = new System.Drawing.Point(320, 160);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(312, 40);
         this.label8.TabIndex = 0;
         // 
         // label9
         // 
         this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label9.Location = new System.Drawing.Point(8, 200);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(312, 40);
         this.label9.TabIndex = 0;
         // 
         // label4
         // 
         this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label4.Location = new System.Drawing.Point(320, 80);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(312, 40);
         this.label4.TabIndex = 0;
         // 
         // label5
         // 
         this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label5.Location = new System.Drawing.Point(8, 120);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(312, 40);
         this.label5.TabIndex = 0;
         // 
         // label6
         // 
         this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label6.Location = new System.Drawing.Point(320, 120);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(312, 40);
         this.label6.TabIndex = 0;
         // 
         // label7
         // 
         this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label7.Location = new System.Drawing.Point(8, 160);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(312, 40);
         this.label7.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label1.Location = new System.Drawing.Point(8, 40);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(312, 40);
         this.label1.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label2.Location = new System.Drawing.Point(320, 40);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(312, 40);
         this.label2.TabIndex = 0;
         // 
         // label3
         // 
         this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label3.Location = new System.Drawing.Point(8, 80);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(312, 40);
         this.label3.TabIndex = 0;
         // 
         // label10
         // 
         this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label10.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label10.Location = new System.Drawing.Point(320, 200);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(312, 40);
         this.label10.TabIndex = 0;
         // 
         // label13
         // 
         this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label13.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label13.Location = new System.Drawing.Point(8, 280);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(312, 40);
         this.label13.TabIndex = 0;
         // 
         // label35
         // 
         this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label35.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
         this.label35.Location = new System.Drawing.Point(8, 8);
         this.label35.Name = "label35";
         this.label35.Size = new System.Drawing.Size(312, 32);
         this.label35.TabIndex = 0;
         // 
         // label28
         // 
         this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label28.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label28.Location = new System.Drawing.Point(320, 560);
         this.label28.Name = "label28";
         this.label28.Size = new System.Drawing.Size(312, 40);
         this.label28.TabIndex = 0;
         // 
         // label29
         // 
         this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label29.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label29.Location = new System.Drawing.Point(8, 600);
         this.label29.Name = "label29";
         this.label29.Size = new System.Drawing.Size(312, 40);
         this.label29.TabIndex = 0;
         // 
         // label26
         // 
         this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label26.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label26.Location = new System.Drawing.Point(320, 520);
         this.label26.Name = "label26";
         this.label26.Size = new System.Drawing.Size(312, 40);
         this.label26.TabIndex = 0;
         // 
         // label27
         // 
         this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label27.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label27.Location = new System.Drawing.Point(8, 560);
         this.label27.Name = "label27";
         this.label27.Size = new System.Drawing.Size(312, 40);
         this.label27.TabIndex = 0;
         // 
         // label24
         // 
         this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label24.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label24.Location = new System.Drawing.Point(320, 480);
         this.label24.Name = "label24";
         this.label24.Size = new System.Drawing.Size(312, 40);
         this.label24.TabIndex = 0;
         // 
         // label25
         // 
         this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label25.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label25.Location = new System.Drawing.Point(8, 520);
         this.label25.Name = "label25";
         this.label25.Size = new System.Drawing.Size(312, 40);
         this.label25.TabIndex = 0;
         // 
         // label22
         // 
         this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label22.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label22.Location = new System.Drawing.Point(320, 440);
         this.label22.Name = "label22";
         this.label22.Size = new System.Drawing.Size(312, 40);
         this.label22.TabIndex = 0;
         // 
         // label23
         // 
         this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label23.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label23.Location = new System.Drawing.Point(8, 480);
         this.label23.Name = "label23";
         this.label23.Size = new System.Drawing.Size(312, 40);
         this.label23.TabIndex = 0;
         // 
         // label20
         // 
         this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label20.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label20.Location = new System.Drawing.Point(320, 400);
         this.label20.Name = "label20";
         this.label20.Size = new System.Drawing.Size(312, 40);
         this.label20.TabIndex = 0;
         // 
         // label21
         // 
         this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label21.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label21.Location = new System.Drawing.Point(8, 440);
         this.label21.Name = "label21";
         this.label21.Size = new System.Drawing.Size(312, 40);
         this.label21.TabIndex = 0;
         // 
         // label19
         // 
         this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label19.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label19.Location = new System.Drawing.Point(8, 400);
         this.label19.Name = "label19";
         this.label19.Size = new System.Drawing.Size(312, 40);
         this.label19.TabIndex = 0;
         // 
         // label18
         // 
         this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label18.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label18.Location = new System.Drawing.Point(320, 360);
         this.label18.Name = "label18";
         this.label18.Size = new System.Drawing.Size(312, 40);
         this.label18.TabIndex = 0;
         // 
         // label15
         // 
         this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label15.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label15.Location = new System.Drawing.Point(8, 320);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(312, 40);
         this.label15.TabIndex = 0;
         // 
         // label14
         // 
         this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label14.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label14.Location = new System.Drawing.Point(320, 280);
         this.label14.Name = "label14";
         this.label14.Size = new System.Drawing.Size(312, 40);
         this.label14.TabIndex = 0;
         // 
         // label17
         // 
         this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label17.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label17.Location = new System.Drawing.Point(8, 360);
         this.label17.Name = "label17";
         this.label17.Size = new System.Drawing.Size(312, 40);
         this.label17.TabIndex = 0;
         // 
         // label16
         // 
         this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label16.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label16.Location = new System.Drawing.Point(320, 320);
         this.label16.Name = "label16";
         this.label16.Size = new System.Drawing.Size(312, 40);
         this.label16.TabIndex = 0;
         // 
         // label11
         // 
         this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label11.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label11.Location = new System.Drawing.Point(8, 240);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(312, 40);
         this.label11.TabIndex = 0;
         // 
         // label30
         // 
         this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label30.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label30.Location = new System.Drawing.Point(320, 600);
         this.label30.Name = "label30";
         this.label30.Size = new System.Drawing.Size(312, 40);
         this.label30.TabIndex = 0;
         // 
         // label36
         // 
         this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label36.Location = new System.Drawing.Point(320, 8);
         this.label36.Name = "label36";
         this.label36.Size = new System.Drawing.Size(312, 32);
         this.label36.TabIndex = 0;
         // 
         // label12
         // 
         this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label12.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label12.Location = new System.Drawing.Point(320, 240);
         this.label12.Name = "label12";
         this.label12.Size = new System.Drawing.Size(312, 40);
         this.label12.TabIndex = 0;
         // 
         // label34
         // 
         this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label34.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label34.Location = new System.Drawing.Point(320, 680);
         this.label34.Name = "label34";
         this.label34.Size = new System.Drawing.Size(312, 40);
         this.label34.TabIndex = 0;
         // 
         // label33
         // 
         this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label33.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label33.Location = new System.Drawing.Point(8, 680);
         this.label33.Name = "label33";
         this.label33.Size = new System.Drawing.Size(312, 40);
         this.label33.TabIndex = 0;
         // 
         // label32
         // 
         this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label32.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label32.Location = new System.Drawing.Point(320, 640);
         this.label32.Name = "label32";
         this.label32.Size = new System.Drawing.Size(312, 40);
         this.label32.TabIndex = 0;
         // 
         // label31
         // 
         this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label31.ImageAlign = System.Drawing.ContentAlignment.TopRight;
         this.label31.Location = new System.Drawing.Point(8, 640);
         this.label31.Name = "label31";
         this.label31.Size = new System.Drawing.Size(312, 40);
         this.label31.TabIndex = 0;
         // 
         // Client
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(640, 733);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.label36,
                                                                      this.label35,
                                                                      this.label33,
                                                                      this.label34,
                                                                      this.label31,
                                                                      this.label32,
                                                                      this.label29,
                                                                      this.label30,
                                                                      this.label27,
                                                                      this.label28,
                                                                      this.label25,
                                                                      this.label26,
                                                                      this.label23,
                                                                      this.label24,
                                                                      this.label21,
                                                                      this.label22,
                                                                      this.label19,
                                                                      this.label20,
                                                                      this.label17,
                                                                      this.label18,
                                                                      this.label15,
                                                                      this.label16,
                                                                      this.label13,
                                                                      this.label14,
                                                                      this.label11,
                                                                      this.label12,
                                                                      this.label9,
                                                                      this.label10,
                                                                      this.label5,
                                                                      this.label6,
                                                                      this.label7,
                                                                      this.label8,
                                                                      this.label3,
                                                                      this.label4,
                                                                      this.label2,
                                                                      this.label1});
         this.Name = "Client";
         this.Text = "Client";
         this.ResumeLayout(false);

      }
		#endregion

      [STAThread]
      static void Main()
      {
         Application.Run( new Client() );
      }

   } // end class Client

} // end namespace TemperatureClient

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