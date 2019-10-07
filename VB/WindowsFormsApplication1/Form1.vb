Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Private workbook As IWorkbook
		Public Sub New()
			InitializeComponent()
			workbook = spreadsheetControl1.Document
		End Sub

		Private Sub buttonFreezeRow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFreezeRow.Click
			'Access the active worksheet.
			Dim worksheet As Worksheet = workbook.Worksheets.ActiveWorksheet

            ' Access the cell range that is currently visible.
            Dim visibleRange As CellRange = spreadsheetControl1.VisibleRange

            ' Freeze the top visible row.
            worksheet.FreezeRows(0, visibleRange)
		End Sub

		Private Sub buttonFreezeColumn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFreezeColumn.Click
			'Access the active worksheet.
			Dim worksheet As Worksheet = workbook.Worksheets.ActiveWorksheet

            ' Access the cell range that is currently visible.
            Dim visibleRange As CellRange = spreadsheetControl1.VisibleRange

            ' Freeze the first visible column.
            worksheet.FreezeColumns(0, visibleRange)
		End Sub

		#Region "#FreezePanes"
		Private Sub buttonFreezePanes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonFreezePanes.Click
			'Access the active worksheet.
			Dim worksheet As Worksheet = workbook.Worksheets.ActiveWorksheet

            ' Access the cell range that is currently visible.
            Dim visibleRange As CellRange = spreadsheetControl1.VisibleRange

            ' Access the active cell. 
            Dim activeCell As Cell = spreadsheetControl1.ActiveCell

			Dim rowOffset As Integer = activeCell.RowIndex - visibleRange.TopRowIndex - 1
			Dim columnOffset As Integer = activeCell.ColumnIndex - visibleRange.LeftColumnIndex - 1

			' If the active cell is outside the visible range of cells, no rows and columns are frozen.
			If (Not visibleRange.IsIntersecting(activeCell)) Then
				Return
			End If

			If activeCell.ColumnIndex = visibleRange.LeftColumnIndex Then
				' If the active cell matches the top left visible cell, no rows and columns are frozen.
				If activeCell.RowIndex = visibleRange.TopRowIndex Then
					Return
				Else
					' Freeze visible rows above the active cell if it is located in the leftmost visible column.
					worksheet.FreezeRows(rowOffset, visibleRange)
				End If

			ElseIf activeCell.RowIndex = visibleRange.TopRowIndex Then
				' Freeze visible columns to the left of the active cell if it is located in the topmost visible row.
				worksheet.FreezeColumns(columnOffset, visibleRange)

			Else
				' Freeze both rows and columns above and to the left of the active cell.
				worksheet.FreezePanes(rowOffset, columnOffset, visibleRange)
			End If
		End Sub
		#End Region ' #FreezePanes

		Private Sub buttonUnfreezePanes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonUnfreezePanes.Click
			Dim worksheet As Worksheet = workbook.Worksheets.ActiveWorksheet
			' Unfreeze rows and columns.
			worksheet.UnfreezePanes()
		End Sub
	End Class
End Namespace
