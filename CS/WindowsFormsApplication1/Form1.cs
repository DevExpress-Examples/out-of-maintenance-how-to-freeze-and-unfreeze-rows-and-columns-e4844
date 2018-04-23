using System;
using System.Windows.Forms;
using DevExpress.Spreadsheet;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        IWorkbook workbook;
        public Form1() {
            InitializeComponent();
            workbook = spreadsheetControl1.Document;
        }

        private void buttonFreezeRow_Click(object sender, EventArgs e) {
            //Access the active worksheet.
            Worksheet worksheet = workbook.Worksheets.ActiveWorksheet;

            // Access the cell range that is currently visible.
            Range visibleRange = spreadsheetControl1.VisibleRange;

            // Freeze the top visible row.
            worksheet.FreezeRows(0, visibleRange);
        }

        private void buttonFreezeColumn_Click(object sender, EventArgs e) {
            //Access the active worksheet.
            Worksheet worksheet = workbook.Worksheets.ActiveWorksheet;

            // Access the cell range that is currently visible.
            Range visibleRange = spreadsheetControl1.VisibleRange;

            // Freeze the first visible column.
            worksheet.FreezeColumns(0, visibleRange);
        }

        #region #FreezePanes
        private void buttonFreezePanes_Click(object sender, EventArgs e) {
            //Access the active worksheet.
            Worksheet worksheet = workbook.Worksheets.ActiveWorksheet;

            // Access the cell range that is currently visible.
            Range visibleRange = spreadsheetControl1.VisibleRange;

            // Access the active cell. 
            Cell activeCell = spreadsheetControl1.ActiveCell;

            int rowOffset = activeCell.RowIndex - visibleRange.TopRowIndex - 1;
            int columnOffset = activeCell.ColumnIndex - visibleRange.LeftColumnIndex - 1;

            // If the active cell is outside the visible range of cells, no rows and columns are frozen.
            if (!visibleRange.IsIntersecting(activeCell)) {
                return;
            }

            if (activeCell.ColumnIndex == visibleRange.LeftColumnIndex) {
                // If the active cell matches the top left visible cell, no rows and columns are frozen.
                if (activeCell.RowIndex == visibleRange.TopRowIndex) { return; }
                else
                    // Freeze visible rows above the active cell if it is located in the leftmost visible column.
                    worksheet.FreezeRows(rowOffset, visibleRange);
            }

            else if (activeCell.RowIndex == visibleRange.TopRowIndex) {
                // Freeze visible columns to the left of the active cell if it is located in the topmost visible row.
                worksheet.FreezeColumns(columnOffset, visibleRange);
            }

            else {
                // Freeze both rows and columns above and to the left of the active cell.
                worksheet.FreezePanes(rowOffset, columnOffset, visibleRange);
            }
        }
        #endregion #FreezePanes

        private void buttonUnfreezePanes_Click(object sender, EventArgs e) {
            Worksheet worksheet = workbook.Worksheets.ActiveWorksheet;
            // Unfreeze rows and columns.
            worksheet.UnfreezePanes();
        }
    }
}
