using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ASimpleProject
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ASimpleProgram : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Label welcomeLabel;
      private System.Windows.Forms.PictureBox bugPictureBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ASimpleProgram()
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
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ASimpleProgram));
         this.welcomeLabel = new System.Windows.Forms.Label();
         this.bugPictureBox = new System.Windows.Forms.PictureBox();
         this.SuspendLayout();
         // 
         // welcomeLabel
         // 
         this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.welcomeLabel.Location = new System.Drawing.Point(19, 8);
         this.welcomeLabel.Name = "welcomeLabel";
         this.welcomeLabel.Size = new System.Drawing.Size(254, 48);
         this.welcomeLabel.TabIndex = 0;
         this.welcomeLabel.Text = "Visual C# .NET";
         this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // bugPictureBox
         // 
         this.bugPictureBox.Image = ((System.Drawing.Bitmap)(resources.GetObject("bugPictureBox.Image")));
         this.bugPictureBox.Location = new System.Drawing.Point(58, 56);
         this.bugPictureBox.Name = "bugPictureBox";
         this.bugPictureBox.Size = new System.Drawing.Size(176, 200);
         this.bugPictureBox.TabIndex = 1;
         this.bugPictureBox.TabStop = false;
         // 
         // ASimpleProgram
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.bugPictureBox,
                                                                      this.welcomeLabel});
         this.Name = "ASimpleProgram";
         this.Text = "A Simple Program";
         this.Load += new System.EventHandler(this.ASimpleProgram_Load);
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ASimpleProgram());
		}

      private void ASimpleProgram_Load(object sender, System.EventArgs e)
      {
         welcomeLabel.Text = "C#";      
      }
	}
}
