// Fig F.3: Unicode.cs
// Using unicode encoding


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Unicode
{
   /// <summary>
   /// Summary description for Unicode.
   /// </summary>
   public class Unicode : System.Windows.Forms.Form
   {
      internal System.Windows.Forms.Label lblChinese;
      internal System.Windows.Forms.Label lblSpanish;
      internal System.Windows.Forms.Label lblRussian;
      internal System.Windows.Forms.Label lblPortuguese;
      internal System.Windows.Forms.Label lblJapanese;
      internal System.Windows.Forms.Label lblGerman;
      internal System.Windows.Forms.Label lblFrench;
      internal System.Windows.Forms.Label lblEnglish;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

		#region Windows Form Designer generated code
		
      public Unicode()
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
      
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblChinese = new System.Windows.Forms.Label();
         this.lblSpanish = new System.Windows.Forms.Label();
         this.lblRussian = new System.Windows.Forms.Label();
         this.lblPortuguese = new System.Windows.Forms.Label();
         this.lblJapanese = new System.Windows.Forms.Label();
         this.lblGerman = new System.Windows.Forms.Label();
         this.lblFrench = new System.Windows.Forms.Label();
         this.lblEnglish = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblChinese
         // 
         this.lblChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblChinese.Location = new System.Drawing.Point(336, 152);
         this.lblChinese.Name = "lblChinese";
         this.lblChinese.Size = new System.Drawing.Size(280, 32);
         this.lblChinese.TabIndex = 17;
         // 
         // lblSpanish
         // 
         this.lblSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblSpanish.Location = new System.Drawing.Point(336, 104);
         this.lblSpanish.Name = "lblSpanish";
         this.lblSpanish.Size = new System.Drawing.Size(280, 32);
         this.lblSpanish.TabIndex = 16;
         // 
         // lblRussian
         // 
         this.lblRussian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblRussian.Location = new System.Drawing.Point(336, 56);
         this.lblRussian.Name = "lblRussian";
         this.lblRussian.Size = new System.Drawing.Size(280, 32);
         this.lblRussian.TabIndex = 15;
         // 
         // lblPortuguese
         // 
         this.lblPortuguese.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblPortuguese.Location = new System.Drawing.Point(336, 8);
         this.lblPortuguese.Name = "lblPortuguese";
         this.lblPortuguese.Size = new System.Drawing.Size(280, 32);
         this.lblPortuguese.TabIndex = 14;
         // 
         // lblJapanese
         // 
         this.lblJapanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblJapanese.Location = new System.Drawing.Point(8, 152);
         this.lblJapanese.Name = "lblJapanese";
         this.lblJapanese.Size = new System.Drawing.Size(304, 32);
         this.lblJapanese.TabIndex = 13;
         // 
         // lblGerman
         // 
         this.lblGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblGerman.Location = new System.Drawing.Point(8, 104);
         this.lblGerman.Name = "lblGerman";
         this.lblGerman.Size = new System.Drawing.Size(304, 32);
         this.lblGerman.TabIndex = 12;
         // 
         // lblFrench
         // 
         this.lblFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblFrench.Location = new System.Drawing.Point(8, 56);
         this.lblFrench.Name = "lblFrench";
         this.lblFrench.Size = new System.Drawing.Size(304, 32);
         this.lblFrench.TabIndex = 11;
         // 
         // lblEnglish
         // 
         this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.lblEnglish.Location = new System.Drawing.Point(8, 8);
         this.lblEnglish.Name = "lblEnglish";
         this.lblEnglish.Size = new System.Drawing.Size(304, 32);
         this.lblEnglish.TabIndex = 10;
         // 
         // Unicode
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(624, 197);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.lblChinese,
                                                                      this.lblSpanish,
                                                                      this.lblRussian,
                                                                      this.lblPortuguese,
                                                                      this.lblJapanese,
                                                                      this.lblGerman,
                                                                      this.lblFrench,
                                                                      this.lblEnglish});
         this.Name = "Unicode";
         this.Text = "Unicode";
         this.Load += new System.EventHandler(this.Unicode_Load);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new Unicode());
      }

      private void Unicode_Load(object sender, System.EventArgs e)
      {
         // English
         char[] english = {'\u0057', '\u0065', '\u006C',  
                             '\u0063', '\u006F', '\u006D', '\u0065', '\u0020',
                             '\u0074', '\u006F', '\u0020' };

         lblEnglish.Text = new string(english) + 
            "Unicode" + '\u0021';
                             
         // French
         char[] french = { '\u0042', '\u0069', '\u0065', 
                            '\u006E', '\u0076', '\u0065', '\u006E', '\u0075',
                            '\u0065', '\u0020', '\u0061', '\u0075', '\u0020' };

         lblFrench.Text = new string(french) + 
            "Unicode" + '\u0021';

         // German
         char[] german = {'\u0057', '\u0069', '\u006C', 
                            '\u006B', '\u006F', '\u006D', '\u006D', '\u0065',
                            '\u006E', '\u0020', '\u007A', '\u0075', '\u0020'};
                                  
         lblGerman.Text =  new string(german) + 
            "Unicode" + '\u0021';

         // Japanese
         char[] japanese = { '\u3078',  '\u3087', '\u3045',
                              '\u3053', '\u305D', '\u0021'};                    

         lblJapanese.Text = "Unicode" + new string(japanese);
                              
         // Portuguese
         char[] portuguese = {'\u0053', '\u0065', '\u006A', 
                                '\u0061', '\u0020', '\u0062', '\u0065', '\u006D',
                                '\u0020', '\u0076', '\u0069', '\u006E', '\u0064',  
                                '\u006F', '\u0020', '\u0061', '\u0020' };  

         lblPortuguese.Text = new string(portuguese) + 
            "Unicode" + '\u0021';
                                 
         // Russian
         char[] russian = {  '\u0414', '\u043E', '\u0431', 
                             '\u0440', '\u043E', '\u0020', '\u043F', '\u043E', 
                             '\u0436', '\u0430', '\u043B', '\u043E', '\u0432',
                             '\u0430', '\u0442', '\u044A', '\u0020', '\u0432', 
                             '\u0020' };                    

         lblRussian.Text = new string(russian) + 
            "Unicode" + '\u0021';
                                
         // Spanish
         char[] spanish = {'\u0042', '\u0069', '\u0065', 
                           '\u006E', '\u0076', '\u0065', '\u006E', '\u0069', 
                           '\u0064', '\u006F', '\u0020', '\u0061', '\u0020' };

         lblSpanish.Text = new string(spanish) + 
            "Unicode" + '\u0021';
                                   
         // Simplified Chinese
         char[] chinese = {'\u6B22', '\u8FCE', '\u4F7F', 
                             '\u7528', '\u0020' };        

         lblChinese.Text = new string(chinese) +  
            "Unicode" + '\u0021';

      }  // end method Unicode_Load
   } // end class Unicode
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