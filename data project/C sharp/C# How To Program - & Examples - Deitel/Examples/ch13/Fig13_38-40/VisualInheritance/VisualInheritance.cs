using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace VisualInheritance
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class VisualInheritance : System.Windows.Forms.Form
	{
      private System.Windows.Forms.Label bugsLabel;
      private System.Windows.Forms.Button learnMoreButton;
      private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public VisualInheritance()
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
         this.bugsLabel = new System.Windows.Forms.Label();
         this.learnMoreButton = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // bugsLabel
         // 
         this.bugsLabel.BackColor = System.Drawing.Color.White;
         this.bugsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
         this.bugsLabel.ForeColor = System.Drawing.Color.MidnightBlue;
         this.bugsLabel.Location = new System.Drawing.Point(8, 8);
         this.bugsLabel.Name = "bugsLabel";
         this.bugsLabel.Size = new System.Drawing.Size(272, 80);
         this.bugsLabel.TabIndex = 0;
         this.bugsLabel.Text = "Bugs, Bugs, Bugs";
         this.bugsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // learnMoreButton
         // 
         this.learnMoreButton.BackColor = System.Drawing.Color.White;
         this.learnMoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
         this.learnMoreButton.ForeColor = System.Drawing.Color.MidnightBlue;
         this.learnMoreButton.Location = new System.Drawing.Point(8, 104);
         this.learnMoreButton.Name = "learnMoreButton";
         this.learnMoreButton.Size = new System.Drawing.Size(120, 88);
         this.learnMoreButton.TabIndex = 1;
         this.learnMoreButton.Text = "Learn More";
         this.learnMoreButton.Click += new System.EventHandler(this.learnMoreButton_Click);
         // 
         // label1
         // 
         this.label1.BackColor = System.Drawing.Color.White;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
         this.label1.Location = new System.Drawing.Point(8, 216);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(272, 40);
         this.label1.TabIndex = 2;
         this.label1.Text = "Copyright 2002, by Bug2Bug.com";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // VisualInheritance
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.label1,
                                                                      this.learnMoreButton,
                                                                      this.bugsLabel});
         this.Name = "VisualInheritance";
         this.Text = "Visual Inheritance";
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run( new VisualInheritance() );
		}

      private void learnMoreButton_Click( object sender, 
         System.EventArgs e )
      {
         MessageBox.Show( 
            "Bugs, Bugs, Bugs is a product of Bug2Bug.com", 
            "Learn More", MessageBoxButtons.OK, 
            MessageBoxIcon.Information );
      }
	}
}
