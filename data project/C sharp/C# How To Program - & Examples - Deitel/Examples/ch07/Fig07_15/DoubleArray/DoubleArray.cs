// Fig. 7.15: DoubleArray.cs
// Manipulating a double-subscripted array.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DoubleArray
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class DoubleArray : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button showOutputButton;
      private System.Windows.Forms.Label outputLabel;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      int[][] grades;
      int students, exams;

      public DoubleArray()
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
         this.showOutputButton = new System.Windows.Forms.Button();
         this.outputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // showOutputButton
         // 
         this.showOutputButton.Location = new System.Drawing.Point(106, 8);
         this.showOutputButton.Name = "showOutputButton";
         this.showOutputButton.Size = new System.Drawing.Size(80, 23);
         this.showOutputButton.TabIndex = 0;
         this.showOutputButton.Text = "Show Output";
         this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(10, 48);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(272, 152);
         this.outputLabel.TabIndex = 1;
         // 
         // DoubleArray
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 205);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel,
                                                                      this.showOutputButton});
         this.Name = "DoubleArray";
         this.Text = "DoubleArray";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new DoubleArray());
      }

      private void showOutputButton_Click( object sender, 
         System.EventArgs e )
      {
         grades = new int[ 3 ][];
         grades[ 0 ] =  new int[]{ 77, 68, 86, 73 };
         grades[ 1 ] =  new int[]{ 96, 87, 89, 81 };
         grades[ 2 ] =  new int[]{ 70, 90, 86, 81 };

         students = grades.Length;      // number of students
         exams = grades[ 0 ].Length;    // number of exams

         // line up column headings
         outputLabel.Text = "                   ";

         // output the column headings
         for ( int i = 0; i < exams; i++ )
            outputLabel.Text += "[" + i + "]  ";

         // output the rows
         for ( int i = 0; i < students; i++ )
         {
            outputLabel.Text += "\ngrades[" + i + "]   ";
         
            for ( int j = 0; j < exams; j++ )
               outputLabel.Text += grades[ i ][ j ] + "   ";
         }

         outputLabel.Text += "\n\nLowest grade: " + Minimum() +
            "\nHighest grade: " + Maximum() + "\n";

         for ( int i = 0; i < students; i++ )
            outputLabel.Text += "\nAverage for student " + i + " is " +
               Average( grades[ i ] );

      } // end method showOutputButton_Click

      // find minimum grade in grades array
      public int Minimum()
      {
         int lowGrade = 100;

         for ( int i = 0; i < students; i++ )

            for ( int j = 0; j < exams; j++ )

               if ( grades[ i ][ j ] < lowGrade )
                  lowGrade = grades[ i ][ j ];
      
         return lowGrade;
      }
   
      // find maximum grade in grades array
      public int Maximum()
      {
         int highGrade = 0;

         for ( int i = 0; i < students; i++ )

            for ( int j = 0; j < exams; j++ )

               if ( grades[ i ][ j ] > highGrade )
                  highGrade = grades[ i ][ j ];
      
         return highGrade;
      }

      // determine average grade for a particular student
      public double Average( int[] setOfGrades )
      {
         int total = 0;

         for ( int i = 0; i < setOfGrades.Length; i++ )
            total += setOfGrades[ i ];

         return ( double ) total / setOfGrades.Length;
      }

   } // end class DoubleArray
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