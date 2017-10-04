// Fig. 6.4: MaximumValue.cs
// Finding the maximum of three double values.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MaximumValue
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class MaximumValue : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label firstNumberLabel;
      private System.Windows.Forms.Label secondNumberLabel;
      private System.Windows.Forms.Label thirdNumberLabel;
      private System.Windows.Forms.Label maximumLabel;
      private System.Windows.Forms.TextBox firstNumberTextBox;
      private System.Windows.Forms.TextBox secondNumberTextBox;
      private System.Windows.Forms.TextBox thirdNumberTextBox;
      private System.Windows.Forms.Button calculateButton;
     
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public MaximumValue()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
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
         this.calculateButton = new System.Windows.Forms.Button();
         this.secondNumberTextBox = new System.Windows.Forms.TextBox();
         this.thirdNumberTextBox = new System.Windows.Forms.TextBox();
         this.firstNumberLabel = new System.Windows.Forms.Label();
         this.secondNumberLabel = new System.Windows.Forms.Label();
         this.thirdNumberLabel = new System.Windows.Forms.Label();
         this.maximumLabel = new System.Windows.Forms.Label();
         this.firstNumberTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // calculateButton
         // 
         this.calculateButton.Location = new System.Drawing.Point(24, 120);
         this.calculateButton.Name = "calculateButton";
         this.calculateButton.Size = new System.Drawing.Size(112, 23);
         this.calculateButton.TabIndex = 0;
         this.calculateButton.Text = "Calculate Maximum";
         this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
         // 
         // secondNumberTextBox
         // 
         this.secondNumberTextBox.Location = new System.Drawing.Point(176, 49);
         this.secondNumberTextBox.Name = "secondNumberTextBox";
         this.secondNumberTextBox.TabIndex = 2;
         this.secondNumberTextBox.Text = "";
         // 
         // thirdNumberTextBox
         // 
         this.thirdNumberTextBox.Location = new System.Drawing.Point(176, 81);
         this.thirdNumberTextBox.Name = "thirdNumberTextBox";
         this.thirdNumberTextBox.TabIndex = 3;
         this.thirdNumberTextBox.Text = "";
         // 
         // firstNumberLabel
         // 
         this.firstNumberLabel.Location = new System.Drawing.Point(8, 16);
         this.firstNumberLabel.Name = "firstNumberLabel";
         this.firstNumberLabel.Size = new System.Drawing.Size(136, 23);
         this.firstNumberLabel.TabIndex = 4;
         this.firstNumberLabel.Text = "First Floating-Point Value:";
         // 
         // secondNumberLabel
         // 
         this.secondNumberLabel.Location = new System.Drawing.Point(8, 48);
         this.secondNumberLabel.Name = "secondNumberLabel";
         this.secondNumberLabel.Size = new System.Drawing.Size(152, 23);
         this.secondNumberLabel.TabIndex = 5;
         this.secondNumberLabel.Text = "Second Floating-Point Value:";
         // 
         // thirdNumberLabel
         // 
         this.thirdNumberLabel.Location = new System.Drawing.Point(8, 80);
         this.thirdNumberLabel.Name = "thirdNumberLabel";
         this.thirdNumberLabel.Size = new System.Drawing.Size(144, 23);
         this.thirdNumberLabel.TabIndex = 6;
         this.thirdNumberLabel.Text = "Third Floating-Point Value:";
         // 
         // maximumLabel
         // 
         this.maximumLabel.Location = new System.Drawing.Point(176, 120);
         this.maximumLabel.Name = "maximumLabel";
         this.maximumLabel.Size = new System.Drawing.Size(100, 80);
         this.maximumLabel.TabIndex = 7;
         // 
         // firstNumberTextBox
         // 
         this.firstNumberTextBox.Location = new System.Drawing.Point(176, 16);
         this.firstNumberTextBox.Name = "firstNumberTextBox";
         this.firstNumberTextBox.TabIndex = 1;
         this.firstNumberTextBox.Text = "";
         // 
         // MaximumValue
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 205);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.firstNumberTextBox,
                                                                      this.maximumLabel,
                                                                      this.thirdNumberLabel,
                                                                      this.secondNumberLabel,
                                                                      this.firstNumberLabel,
                                                                      this.thirdNumberTextBox,
                                                                      this.secondNumberTextBox,
                                                                      this.calculateButton});
         this.Name = "MaximumValue";
         this.Text = "MaximumValue";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new MaximumValue());
      }

      // Method Maximum uses method Math.Max to determine the
      // maximum value among the three double arguments
      double Maximum( double x, double y, double z )
      {
         return Math.Max( x, Math.Max( y, z ) );
      }

      // get the floating-point values that the user entered and
      // invoke method Maximum to determine the maximum value
      private void calculateButton_Click(object sender, System.EventArgs e)
      {
         // get inputted values and convert strings to doubles
         double number1 = 
            Double.Parse( firstNumberTextBox.Text );

         double number2 = 
            Double.Parse( secondNumberTextBox.Text );

         double number3 = 
            Double.Parse( thirdNumberTextBox.Text );

         // invoke method Maximum to determine the largest value
         double maximum = Maximum( number1, number2, number3 );

         // display maximum value
         maximumLabel.Text = "maximum is: " + maximum;

      }  // end method calculateButton_Click
   
   } // end class MaximumValue

} // end namespace MaximumValue
