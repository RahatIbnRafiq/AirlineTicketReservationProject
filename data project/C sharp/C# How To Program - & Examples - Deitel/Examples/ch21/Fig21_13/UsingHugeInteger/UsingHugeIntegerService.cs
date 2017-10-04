// Fig. 21.13: UsingHugeIntegerService.cs
// Using the HugeInteger Web Service.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Web.Services.Protocols;

namespace UsingHugeInteger
{
   // allows user to perform operations on large integers
   public class UsingHugeIntService : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label promptLabel;
      private System.Windows.Forms.Label resultLabel;

      private System.Windows.Forms.TextBox firstTextBox;
      private System.Windows.Forms.TextBox secondTextBox;

      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.Button subtractButton;
      private System.Windows.Forms.Button biggerButton;
      private System.Windows.Forms.Button smallerButton;
      private System.Windows.Forms.Button equalButton;
   
      private System.ComponentModel.Container components = null;

      // declare a reference Web service
      private localhost.HugeInteger remoteInteger;

      private char[] zeroes = { '0' };

      // default constructor
      public UsingHugeIntService()
      {
         InitializeComponent();

         // instantiate remoteInteger
         remoteInteger = new localhost.HugeInteger();
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.promptLabel = new System.Windows.Forms.Label();
         this.firstTextBox = new System.Windows.Forms.TextBox();
         this.secondTextBox = new System.Windows.Forms.TextBox();
         this.addButton = new System.Windows.Forms.Button();
         this.subtractButton = new System.Windows.Forms.Button();
         this.biggerButton = new System.Windows.Forms.Button();
         this.smallerButton = new System.Windows.Forms.Button();
         this.equalButton = new System.Windows.Forms.Button();
         this.resultLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // promptLabel
         // 
         this.promptLabel.AutoSize = true;
         this.promptLabel.Location = new System.Drawing.Point(16, 24);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(287, 13);
         this.promptLabel.TabIndex = 0;
         this.promptLabel.Text = "Please enter two positive numbers up to 100 digits each:";
         // 
         // firstTextBox
         // 
         this.firstTextBox.Font = new System.Drawing.Font("Letter Gothic MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.firstTextBox.Location = new System.Drawing.Point(17, 56);
         this.firstTextBox.Name = "firstTextBox";
         this.firstTextBox.Size = new System.Drawing.Size(711, 21);
         this.firstTextBox.TabIndex = 1;
         this.firstTextBox.Text = "";
         // 
         // secondTextBox
         // 
         this.secondTextBox.Font = new System.Drawing.Font("Letter Gothic MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.secondTextBox.Location = new System.Drawing.Point(17, 88);
         this.secondTextBox.Name = "secondTextBox";
         this.secondTextBox.Size = new System.Drawing.Size(711, 21);
         this.secondTextBox.TabIndex = 2;
         this.secondTextBox.Text = "";
         // 
         // addButton
         // 
         this.addButton.Location = new System.Drawing.Point(84, 128);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(88, 23);
         this.addButton.TabIndex = 3;
         this.addButton.Text = "Add";
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // subtractButton
         // 
         this.subtractButton.Location = new System.Drawing.Point(212, 128);
         this.subtractButton.Name = "subtractButton";
         this.subtractButton.Size = new System.Drawing.Size(88, 23);
         this.subtractButton.TabIndex = 4;
         this.subtractButton.Text = "Subtract";
         this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
         // 
         // biggerButton
         // 
         this.biggerButton.Location = new System.Drawing.Point(332, 128);
         this.biggerButton.Name = "biggerButton";
         this.biggerButton.Size = new System.Drawing.Size(88, 23);
         this.biggerButton.TabIndex = 5;
         this.biggerButton.Text = "Larger Than";
         this.biggerButton.Click += new System.EventHandler(this.biggerButton_Click);
         // 
         // smallerButton
         // 
         this.smallerButton.Location = new System.Drawing.Point(452, 128);
         this.smallerButton.Name = "smallerButton";
         this.smallerButton.Size = new System.Drawing.Size(88, 23);
         this.smallerButton.TabIndex = 6;
         this.smallerButton.Text = "Smaller Than";
         this.smallerButton.Click += new System.EventHandler(this.smallerButton_Click);
         // 
         // equalButton
         // 
         this.equalButton.Location = new System.Drawing.Point(572, 128);
         this.equalButton.Name = "equalButton";
         this.equalButton.Size = new System.Drawing.Size(88, 23);
         this.equalButton.TabIndex = 7;
         this.equalButton.Text = "Equal";
         this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
         // 
         // resultLabel
         // 
         this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.resultLabel.Location = new System.Drawing.Point(16, 176);
         this.resultLabel.Name = "resultLabel";
         this.resultLabel.Size = new System.Drawing.Size(712, 40);
         this.resultLabel.TabIndex = 8;
         // 
         // UsingHugeIntService
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(744, 229);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.resultLabel,
                                                                      this.equalButton,
                                                                      this.smallerButton,
                                                                      this.biggerButton,
                                                                      this.subtractButton,
                                                                      this.addButton,
                                                                      this.secondTextBox,
                                                                      this.firstTextBox,
                                                                      this.promptLabel});
         this.Name = "UsingHugeIntService";
         this.Text = "UsingHugeInteger";
         this.ResumeLayout(false);

      }
      #endregion

      [STAThread]
      static void Main()
      {
         Application.Run( new UsingHugeIntService() );

      } // end Main

      // checks whether two numbers user input are equal
      protected void equalButton_Click( 
         object sender, System.EventArgs e )
      {
         // make sure HugeIntegers do not exceed 100 digits
         if ( CheckSize( firstTextBox, secondTextBox ) )
            return;

         // call Web-service method to determine 
         // whether integers are equal
         if ( remoteInteger.EqualTo(
            firstTextBox.Text, secondTextBox.Text ) )

            resultLabel.Text = firstTextBox.Text.TrimStart( zeroes ) +
               " is equal to " + secondTextBox.Text.TrimStart( zeroes );

         else
            resultLabel.Text = firstTextBox.Text.TrimStart( zeroes ) + 
               " is NOT equal to " + secondTextBox.Text.TrimStart( zeroes );

      } // end method equalButton_Click

      // checks whether first integer input
      // by user is smaller than second
      protected void smallerButton_Click( 
         object sender, System.EventArgs e )
      {
         // make sure HugeIntegers do not exceed 100 digits
         if ( CheckSize( firstTextBox, secondTextBox ) )
            return;

         // call Web-service method to determine whether first
         // integer is smaller than second
         if ( remoteInteger.Smaller( 
            firstTextBox.Text, secondTextBox.Text ) )

            resultLabel.Text = 
               firstTextBox.Text.TrimStart( zeroes ) +
               " is smaller than " + 
               secondTextBox.Text.TrimStart( zeroes );
         else
            resultLabel.Text = 
               firstTextBox.Text.TrimStart( zeroes ) +
               " is NOT smaller than " + 
               secondTextBox.Text.TrimStart( zeroes );

      } // end method smallerButton_Click

      // checks whether first integer input 
      // by user is bigger than second
      protected void biggerButton_Click( 
         object sender, System.EventArgs e )
      {
         // make sure HugeIntegers do not exceed 100 digits
         if ( CheckSize( firstTextBox, secondTextBox ) )
            return;

         // call Web-service method to determine whether first
         // integer is larger than the second
         if ( remoteInteger.Bigger( firstTextBox.Text, 
            secondTextBox.Text ) )

            resultLabel.Text = 
               firstTextBox.Text.TrimStart( zeroes ) +
               " is larger than " + 
               secondTextBox.Text.TrimStart( zeroes );
         else
            resultLabel.Text = 
               firstTextBox.Text.TrimStart( zeroes ) + 
               " is NOT larger than " + 
               secondTextBox.Text.TrimStart( zeroes );

      } // end method biggerButton_Click

      // subtract second integer from first
      protected void subtractButton_Click( 
         object sender, System.EventArgs e )
      {
         // make sure HugeIntegers do not exceed 100 digits
         if ( CheckSize( firstTextBox, secondTextBox ) )
            return;

         // perform subtraction
         try
         {
            string result = remoteInteger.Subtract( 
               firstTextBox.Text, 
               secondTextBox.Text ).TrimStart( zeroes );

            resultLabel.Text = ( ( result == "" ) ? "0" : result );
         }

            // if WebMethod throws an exception, then first
            // argument was smaller than second
         catch ( SoapException )
         {
            MessageBox.Show( 
               "First argument was smaller than the second" );
         }

      } // end method subtractButton_Click

      // adds two integers input by user
      protected void addButton_Click( 
         object sender, System.EventArgs e )
      {
         // make sure HugeInteger does not exceed 100 digits
         // and is not situation where both integers are 100
         // digits long--result in overflow
         if ( firstTextBox.Text.Length > 100 ||
            secondTextBox.Text.Length > 100  ||
            ( firstTextBox.Text.Length == 100 &&
            secondTextBox.Text.Length == 100 ) )
         {
            MessageBox.Show( "HugeIntegers must not be more "
               + "than 100 digits\nBoth integers cannot be of"
               + " length 100: this causes an overflow", 
               "Error", MessageBoxButtons.OK,
               MessageBoxIcon.Information );

            return;
         }

         // perform addition
         resultLabel.Text = remoteInteger.Add( firstTextBox.Text,
            secondTextBox.Text ).TrimStart( zeroes ).ToString();

      } // end method addButton_Click

      // determines whether size of integers is too big
      private bool CheckSize( TextBox first, TextBox second )
      {
         if ( first.Text.Length > 100 || second.Text.Length > 100 )
         {
            MessageBox.Show( "HugeIntegers must be less than 100"
               + " digits", "Error", MessageBoxButtons.OK,
               MessageBoxIcon.Information );

            return true;
         }

         return false;
         
      } // end method CheckSize

   } // end class UsingHugeIntegerService

} // end namespace UsingHugeInteger

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