// Fig. 13.36: UsingMDI.cs
// Demonstrating use of MDI parent and child windows.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UsingMDI
{
   /// <summary>
   /// Summary description for UsingMDI.
   /// </summary>
   public class UsingMDI : System.Windows.Forms.Form
   {
      private System.Windows.Forms.MainMenu mainMenu1;
      private System.Windows.Forms.MenuItem fileMenuItem;
      private System.Windows.Forms.MenuItem newMenuItem;
      private System.Windows.Forms.MenuItem child1MenuItem;
      private System.Windows.Forms.MenuItem child2MenuItem;
      private System.Windows.Forms.MenuItem child3MenuItem;
      private System.Windows.Forms.MenuItem exitMenuItem;
      private System.Windows.Forms.MenuItem formatMenuItem;
      private System.Windows.Forms.MenuItem cascadeMenuItem;
      private System.Windows.Forms.MenuItem 
         tileHorizontalMenuItem;
      private System.Windows.Forms.MenuItem 
         tileVerticalMenuItem;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private 
         System.ComponentModel.Container components = null;

      public UsingMDI()
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
         this.mainMenu1 = new System.Windows.Forms.MainMenu();
         this.fileMenuItem = new System.Windows.Forms.MenuItem();
         this.newMenuItem = new System.Windows.Forms.MenuItem();
         this.child1MenuItem = new System.Windows.Forms.MenuItem();
         this.child2MenuItem = new System.Windows.Forms.MenuItem();
         this.child3MenuItem = new System.Windows.Forms.MenuItem();
         this.exitMenuItem = new System.Windows.Forms.MenuItem();
         this.formatMenuItem = new System.Windows.Forms.MenuItem();
         this.cascadeMenuItem = new System.Windows.Forms.MenuItem();
         this.tileHorizontalMenuItem = new System.Windows.Forms.MenuItem();
         this.tileVerticalMenuItem = new System.Windows.Forms.MenuItem();
         // 
         // mainMenu1
         // 
         this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                  this.fileMenuItem,
                                                                                  this.formatMenuItem});
         // 
         // fileMenuItem
         // 
         this.fileMenuItem.Index = 0;
         this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.newMenuItem,
                                                                                     this.exitMenuItem});
         this.fileMenuItem.Text = "File";
         // 
         // newMenuItem
         // 
         this.newMenuItem.Index = 0;
         this.newMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                    this.child1MenuItem,
                                                                                    this.child2MenuItem,
                                                                                    this.child3MenuItem});
         this.newMenuItem.Text = "New";
         // 
         // child1MenuItem
         // 
         this.child1MenuItem.Index = 0;
         this.child1MenuItem.Text = "Child1";
         this.child1MenuItem.Click += new System.EventHandler(this.child1MenuItem_Click);
         // 
         // child2MenuItem
         // 
         this.child2MenuItem.Index = 1;
         this.child2MenuItem.Text = "Child2";
         this.child2MenuItem.Click += new System.EventHandler(this.child2MenuItem_Click);
         // 
         // child3MenuItem
         // 
         this.child3MenuItem.Index = 2;
         this.child3MenuItem.Text = "Child3";
         this.child3MenuItem.Click += new System.EventHandler(this.child3MenuItem_Click);
         // 
         // exitMenuItem
         // 
         this.exitMenuItem.Index = 1;
         this.exitMenuItem.Text = "Exit";
         this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
         // 
         // formatMenuItem
         // 
         this.formatMenuItem.Index = 1;
         this.formatMenuItem.MdiList = true;
         this.formatMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                       this.cascadeMenuItem,
                                                                                       this.tileHorizontalMenuItem,
                                                                                       this.tileVerticalMenuItem});
         this.formatMenuItem.Text = "Format";
         // 
         // cascadeMenuItem
         // 
         this.cascadeMenuItem.Index = 0;
         this.cascadeMenuItem.Text = "Cascade";
         this.cascadeMenuItem.Click += new System.EventHandler(this.cascadeMenuItem_Click);
         // 
         // tileHorizontalMenuItem
         // 
         this.tileHorizontalMenuItem.Index = 1;
         this.tileHorizontalMenuItem.Text = "Tile Horizontal";
         this.tileHorizontalMenuItem.Click += new System.EventHandler(this.tileHorizontalMenuItem_Click);
         // 
         // tileVerticalMenuItem
         // 
         this.tileVerticalMenuItem.Index = 2;
         this.tileVerticalMenuItem.Text = "Tile Vertical";
         this.tileVerticalMenuItem.Click += new System.EventHandler(this.tileVerticalMenuItem_Click);
         // 
         // UsingMDI
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 275);
         this.IsMdiContainer = true;
         this.Menu = this.mainMenu1;
         this.Name = "UsingMDI";
         this.Text = "UsingMDI";

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run(new UsingMDI());
      }

      // create Child 1 when menu clicked
      private void child1MenuItem_Click(
         object sender, System.EventArgs e )
      {
         // create new child
         Child formChild = new Child( "Child 1", 
            "\\images\\csharphtp1.jpg" );
         formChild.MdiParent = this;   // set parent
         formChild.Show();          // display child
      }

      // create Child 2 when menu clicked
      private void child2MenuItem_Click(
         object sender, System.EventArgs e )
      {
         // create new child
         Child formChild = new Child( "Child 2", 
            "\\images\\vbnethtp2.jpg" );
         formChild.MdiParent = this;   // set parent
         formChild.Show();          // display child
      }

      // create Child 3 when menu clicked
      private void child3MenuItem_Click(
         object sender, System.EventArgs e )
      {
         // create new child
         Child formChild = new Child( "Child 3", 
            "\\images\\pythonhtp1.jpg" );
         formChild.MdiParent = this;   // set parent
         formChild.Show();          // display child
      }

      // exit application
      private void exitMenuItem_Click(
         object sender, System.EventArgs e )
      {
         Application.Exit();
      }

      // set cascade layout
      private void cascadeMenuItem_Click(
         object sender, System.EventArgs e )
      {
         this.LayoutMdi( MdiLayout.Cascade );
      }

      // set TileHorizontal layout
      private void tileHorizontalMenuItem_Click(
         object sender, System.EventArgs e )
      {
         this.LayoutMdi( MdiLayout.TileHorizontal );
      }

      // set TileVertical layout
      private void tileVerticalMenuItem_Click(
         object sender, System.EventArgs e )
      {
         this.LayoutMdi( MdiLayout.TileVertical );
      }

   } // end class UsingMDI
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
