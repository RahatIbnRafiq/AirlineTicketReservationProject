// Fig 17.7: BankUI.cs
// A reusable windows form for the examples in this chapter.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BankLibrary
{
   public class BankUIForm : System.Windows.Forms.Form
   {
      private System.ComponentModel.Container components = null;

      public System.Windows.Forms.Label accountLabel;
      public System.Windows.Forms.TextBox accountTextBox;

      public System.Windows.Forms.Label firstNameLabel;
      public System.Windows.Forms.TextBox firstNameTextBox;

      public System.Windows.Forms.Label lastNameLabel;
      public System.Windows.Forms.TextBox lastNameTextBox;

      public System.Windows.Forms.Label balanceLabel;
      public System.Windows.Forms.TextBox balanceTextBox;

      // number of TextBoxes on Form'
      protected int TextBoxCount = 4;

      // enumeration constants specify TextBox indices
      public enum TextBoxIndices
      {
         ACCOUNT,
         FIRST,
         LAST,
         BALANCE

      } // end enum

      public BankUIForm()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.balanceTextBox = new System.Windows.Forms.TextBox();
         this.lastNameTextBox = new System.Windows.Forms.TextBox();
         this.firstNameTextBox = new System.Windows.Forms.TextBox();
         this.accountTextBox = new System.Windows.Forms.TextBox();
         this.balanceLabel = new System.Windows.Forms.Label();
         this.lastNameLabel = new System.Windows.Forms.Label();
         this.firstNameLabel = new System.Windows.Forms.Label();
         this.accountLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // balanceTextBox
         // 
         this.balanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.balanceTextBox.Location = new System.Drawing.Point(184, 184);
         this.balanceTextBox.Name = "balanceTextBox";
         this.balanceTextBox.Size = new System.Drawing.Size(184, 26);
         this.balanceTextBox.TabIndex = 15;
         this.balanceTextBox.Text = "";
         // 
         // lastNameTextBox
         // 
         this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lastNameTextBox.Location = new System.Drawing.Point(184, 128);
         this.lastNameTextBox.Name = "lastNameTextBox";
         this.lastNameTextBox.Size = new System.Drawing.Size(184, 26);
         this.lastNameTextBox.TabIndex = 14;
         this.lastNameTextBox.Text = "";
         // 
         // firstNameTextBox
         // 
         this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.firstNameTextBox.Location = new System.Drawing.Point(184, 72);
         this.firstNameTextBox.Name = "firstNameTextBox";
         this.firstNameTextBox.Size = new System.Drawing.Size(184, 26);
         this.firstNameTextBox.TabIndex = 13;
         this.firstNameTextBox.Text = "";
         // 
         // accountTextBox
         // 
         this.accountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.accountTextBox.Location = new System.Drawing.Point(184, 16);
         this.accountTextBox.Name = "accountTextBox";
         this.accountTextBox.Size = new System.Drawing.Size(184, 26);
         this.accountTextBox.TabIndex = 16;
         this.accountTextBox.Text = "";
         // 
         // balanceLabel
         // 
         this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.balanceLabel.Location = new System.Drawing.Point(24, 184);
         this.balanceLabel.Name = "balanceLabel";
         this.balanceLabel.Size = new System.Drawing.Size(136, 23);
         this.balanceLabel.TabIndex = 12;
         this.balanceLabel.Text = "Balance";
         this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lastNameLabel
         // 
         this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lastNameLabel.Location = new System.Drawing.Point(24, 128);
         this.lastNameLabel.Name = "lastNameLabel";
         this.lastNameLabel.Size = new System.Drawing.Size(136, 23);
         this.lastNameLabel.TabIndex = 11;
         this.lastNameLabel.Text = "Last Name";
         this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // firstNameLabel
         // 
         this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.firstNameLabel.Location = new System.Drawing.Point(24, 72);
         this.firstNameLabel.Name = "firstNameLabel";
         this.firstNameLabel.Size = new System.Drawing.Size(136, 23);
         this.firstNameLabel.TabIndex = 10;
         this.firstNameLabel.Text = "First Name";
         this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // accountLabel
         // 
         this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.accountLabel.Location = new System.Drawing.Point(24, 16);
         this.accountLabel.Name = "accountLabel";
         this.accountLabel.Size = new System.Drawing.Size(136, 23);
         this.accountLabel.TabIndex = 17;
         this.accountLabel.Text = "Account";
         // 
         // BankUIForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
         this.ClientSize = new System.Drawing.Size(400, 231);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.balanceTextBox,
                                                                      this.lastNameTextBox,
                                                                      this.firstNameTextBox,
                                                                      this.accountTextBox,
                                                                      this.balanceLabel,
                                                                      this.lastNameLabel,
                                                                      this.firstNameLabel,
                                                                      this.accountLabel});
         this.Name = "BankUIForm";
         this.ResumeLayout(false);

      }
		#endregion

      [STAThread]
      static void Main() 
      {
         Application.Run( new BankUIForm() );
      }

      // clear all TextBoxes
      public void ClearTextBoxes()
      {
         // iterate through every Control on form
         for ( int i = 0; i < Controls.Count; i++ )
         {
            Control myControl = Controls[ i ]; // get control

            // determine whether Control is TextBox
            if ( myControl is TextBox )
            {
               // clear Text property (set to empty strng)
               myControl.Text = "";
            }
         }

      } // end method ClearTextBoxes

      // set text box values to string array values
      public void SetTextBoxValues( string[] values )
      {
         // determine whether string array has correct length
         if ( values.Length != TextBoxCount )
         {
            // throw exception if not correct length
            throw( new ArgumentException( "There must be " +
               (TextBoxCount + 1) + " strings in the array" ) );
         }

            // set array values if array has correct length
         else
         {
            // set array values to text box values
            accountTextBox.Text = 
               values[ ( int )TextBoxIndices.ACCOUNT ];
            firstNameTextBox.Text = 
               values[ ( int )TextBoxIndices.FIRST ];
            lastNameTextBox.Text = 
               values[ ( int )TextBoxIndices.LAST ];
            balanceTextBox.Text = 
               values[ ( int )TextBoxIndices.BALANCE ];
         }

      } // end method SetTextBoxValues

      // return text box values as string array
      public string[] GetTextBoxValues()
      {
         string[] values = new string[ TextBoxCount ];

         // copy text box fields to string array
         values[ ( int )TextBoxIndices.ACCOUNT ] = 
            accountTextBox.Text;
         values[ ( int )TextBoxIndices.FIRST ] = 
            firstNameTextBox.Text;
         values[ ( int )TextBoxIndices.LAST ] = 
            lastNameTextBox.Text;
         values[ ( int )TextBoxIndices.BALANCE ] = 
            balanceTextBox.Text;

         return values;

      } // end method GetTextBoxValues

   } // end class BankUIForm
}

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