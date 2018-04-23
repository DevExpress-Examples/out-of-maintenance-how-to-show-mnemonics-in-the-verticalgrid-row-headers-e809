using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication393
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
		private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.Location = new System.Drawing.Point(32, 24);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow1,
            this.editorRow2,
            this.categoryRow1});
            this.vGridControl1.Size = new System.Drawing.Size(280, 352);
            this.vGridControl1.TabIndex = 0;
            this.vGridControl1.CustomDrawRowHeaderCell += new DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(this.vGridControl1_CustomDrawRowHeaderCell);
            // 
            // editorRow1
            // 
            this.editorRow1.Name = "editorRow1";
            this.editorRow1.Properties.Caption = "&TextEdit";
            // 
            // editorRow2
            // 
            this.editorRow2.Height = 16;
            this.editorRow2.Name = "editorRow2";
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow3});
            this.categoryRow1.Name = "categoryRow1";
            // 
            // editorRow3
            // 
            this.editorRow3.Name = "editorRow3";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(728, 422);
            this.Controls.Add(this.vGridControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void vGridControl1_CustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e) {
				e.Appearance.FillRectangle(e.Cache, e.Bounds);
				StringFormat frm = new StringFormat();
				frm.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
				e.Appearance.DrawString(e.Cache, e.Caption, e.Bounds, frm);
				e.Handled = true; 
		}

		private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e) {
			if ((e.Modifiers == Keys.Alt) && (e.KeyCode == Keys.T)){
				vGridControl1.FocusedRow = editorRow1;
				vGridControl1.CloseEditor();
				vGridControl1.ShowEditor();
			}				
		}
	}
}
