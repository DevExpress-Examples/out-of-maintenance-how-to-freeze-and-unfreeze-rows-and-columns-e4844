Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.buttonUnfreezePanes = New System.Windows.Forms.Button()
			Me.buttonFreezePanes = New System.Windows.Forms.Button()
			Me.buttonFreezeColumn = New System.Windows.Forms.Button()
			Me.buttonFreezeRow = New System.Windows.Forms.Button()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.AllowDrop = True
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ","c
			Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Import.ThrowExceptionOnInvalidDocument = False
			Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Size = New System.Drawing.Size(605, 476)
			Me.spreadsheetControl1.TabIndex = 0
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.buttonUnfreezePanes)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.buttonFreezePanes)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.buttonFreezeColumn)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.buttonFreezeRow)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(724, 476)
			Me.splitContainerControl1.SplitterPosition = 114
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' buttonUnfreezePanes
			' 
			Me.buttonUnfreezePanes.Location = New System.Drawing.Point(3, 93)
			Me.buttonUnfreezePanes.Name = "buttonUnfreezePanes"
			Me.buttonUnfreezePanes.Size = New System.Drawing.Size(110, 23)
			Me.buttonUnfreezePanes.TabIndex = 3
			Me.buttonUnfreezePanes.Text = "Unfreeze Panes"
			Me.buttonUnfreezePanes.UseVisualStyleBackColor = True
'			Me.buttonUnfreezePanes.Click += New System.EventHandler(Me.buttonUnfreezePanes_Click);
			' 
			' buttonFreezePanes
			' 
			Me.buttonFreezePanes.Location = New System.Drawing.Point(3, 64)
			Me.buttonFreezePanes.Name = "buttonFreezePanes"
			Me.buttonFreezePanes.Size = New System.Drawing.Size(110, 23)
			Me.buttonFreezePanes.TabIndex = 2
			Me.buttonFreezePanes.Text = "Freeze Panes"
			Me.buttonFreezePanes.UseVisualStyleBackColor = True
'			Me.buttonFreezePanes.Click += New System.EventHandler(Me.buttonFreezePanes_Click);
			' 
			' buttonFreezeColumn
			' 
			Me.buttonFreezeColumn.Location = New System.Drawing.Point(3, 35)
			Me.buttonFreezeColumn.Name = "buttonFreezeColumn"
			Me.buttonFreezeColumn.Size = New System.Drawing.Size(110, 23)
			Me.buttonFreezeColumn.TabIndex = 1
			Me.buttonFreezeColumn.Text = "Freeze Left Column"
			Me.buttonFreezeColumn.UseVisualStyleBackColor = True
'			Me.buttonFreezeColumn.Click += New System.EventHandler(Me.buttonFreezeColumn_Click);
			' 
			' buttonFreezeRow
			' 
			Me.buttonFreezeRow.Location = New System.Drawing.Point(3, 3)
			Me.buttonFreezeRow.Name = "buttonFreezeRow"
			Me.buttonFreezeRow.Size = New System.Drawing.Size(110, 26)
			Me.buttonFreezeRow.TabIndex = 0
			Me.buttonFreezeRow.Text = "Freeze Top Row"
			Me.buttonFreezeRow.UseVisualStyleBackColor = True
'			Me.buttonFreezeRow.Click += New System.EventHandler(Me.buttonFreezeRow_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(724, 476)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents buttonFreezeRow As System.Windows.Forms.Button
		Private WithEvents buttonFreezeColumn As System.Windows.Forms.Button
		Private WithEvents buttonFreezePanes As System.Windows.Forms.Button
		Private WithEvents buttonUnfreezePanes As System.Windows.Forms.Button
	End Class
End Namespace

