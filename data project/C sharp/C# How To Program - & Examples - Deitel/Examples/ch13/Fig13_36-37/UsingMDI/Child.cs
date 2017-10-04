// Fig. 13.37: Child.cs
// Child window of MDI parent.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace UsingMDI
{
	/// <summary>
	/// Summary description for Child.
	/// </summary>
	public class Child : System.Windows.Forms.Form
	{
      private System.Windows.Forms.PictureBox pictureBox;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Child( string title, string fileName )
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

         Text = title; // set title text

         // set image to display in pictureBox
         pictureBox.Image = Image.FromFile( 
            Directory.GetCurrentDirectory() + fileName );
			
		}

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.SuspendLayout();
         // 
         // pictureBox
         // 
         this.pictureBox.Location = new System.Drawing.Point(8, 8);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(272, 256);
         this.pictureBox.TabIndex = 0;
         this.pictureBox.TabStop = false;
         // 
         // Child
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.pictureBox});
         this.Name = "Child";
         this.Text = "Child";
         this.ResumeLayout(false);

      }
		#endregion
	}
}
