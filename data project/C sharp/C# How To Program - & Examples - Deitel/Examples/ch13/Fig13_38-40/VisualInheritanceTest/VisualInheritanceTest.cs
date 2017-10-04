using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace VisualInheritanceTest
{
   public class VisualInheritanceTest : VisualInheritance.VisualInheritance
   {
      private System.Windows.Forms.Button learnProgramButton;
      private System.ComponentModel.IContainer components = null;

      public VisualInheritanceTest()
      {
         // This call is required by the Windows Form Designer.
         InitializeComponent();

         // TODO: Add any initialization after the InitializeComponent call
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

      #region Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.learnProgramButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // learnProgramButton
         // 
         this.learnProgramButton.BackColor = System.Drawing.Color.White;
         this.learnProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
         this.learnProgramButton.ForeColor = System.Drawing.Color.MidnightBlue;
         this.learnProgramButton.Location = new System.Drawing.Point(152, 104);
         this.learnProgramButton.Name = "learnProgramButton";
         this.learnProgramButton.Size = new System.Drawing.Size(120, 88);
         this.learnProgramButton.TabIndex = 3;
         this.learnProgramButton.Text = "Learn the Program";
         this.learnProgramButton.Click += new System.EventHandler(this.learnProgramButton_Click);
         // 
         // VisualInheritanceTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.learnProgramButton});
         this.Name = "VisualInheritanceTest";
         this.ResumeLayout(false);

      }
      #endregion

      // invoke when user clicks Learn the Program Button
      private void learnProgramButton_Click( object sender, 
         System.EventArgs e )
      {
         MessageBox.Show(
            "This program was created by Deitel & Associates",
            "Learn the Program", MessageBoxButtons.OK, 
            MessageBoxIcon.Information );
      }

      static void Main( string[] args )
      {
         Application.Run( new VisualInheritanceTest() );
      }
   }
}

