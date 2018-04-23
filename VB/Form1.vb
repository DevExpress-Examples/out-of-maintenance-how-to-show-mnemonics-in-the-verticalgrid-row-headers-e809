Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication393
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private editorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.editorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Location = New System.Drawing.Point(32, 24)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow1, Me.editorRow2, Me.categoryRow1})
			Me.vGridControl1.Size = New System.Drawing.Size(280, 352)
			Me.vGridControl1.TabIndex = 0
'			Me.vGridControl1.CustomDrawRowHeaderCell += New DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(Me.vGridControl1_CustomDrawRowHeaderCell);
			' 
			' editorRow1
			' 
			Me.editorRow1.Name = "editorRow1"
			Me.editorRow1.Properties.Caption = "&TextEdit"
			' 
			' editorRow2
			' 
			Me.editorRow2.Height = 16
			Me.editorRow2.Name = "editorRow2"
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow3})
			Me.categoryRow1.Name = "categoryRow1"
			' 
			' editorRow3
			' 
			Me.editorRow3.Name = "editorRow3"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(728, 422)
			Me.Controls.Add(Me.vGridControl1)
			Me.KeyPreview = True
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.KeyUp += New System.Windows.Forms.KeyEventHandler(Me.Form1_KeyUp);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub vGridControl1_CustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs) Handles vGridControl1.CustomDrawRowHeaderCell
				e.Appearance.FillRectangle(e.Cache, e.Bounds)
				Dim frm As New StringFormat()
				frm.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
				e.Appearance.DrawString(e.Cache, e.Caption, e.Bounds, frm)
				e.Handled = True
		End Sub

		Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
			If (e.Modifiers = Keys.Alt) AndAlso (e.KeyCode = Keys.T) Then
				vGridControl1.FocusedRow = editorRow1
				vGridControl1.CloseEditor()
				vGridControl1.ShowEditor()
			End If
		End Sub
	End Class
End Namespace
