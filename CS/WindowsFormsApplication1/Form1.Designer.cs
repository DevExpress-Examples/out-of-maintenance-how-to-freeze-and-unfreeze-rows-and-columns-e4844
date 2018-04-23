namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.buttonUnfreezePanes = new System.Windows.Forms.Button();
            this.buttonFreezePanes = new System.Windows.Forms.Button();
            this.buttonFreezeColumn = new System.Windows.Forms.Button();
            this.buttonFreezeRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.AllowDrop = true;
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ',';
            this.spreadsheetControl1.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Import.ThrowExceptionOnInvalidDocument = false;
            this.spreadsheetControl1.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Size = new System.Drawing.Size(605, 476);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.buttonUnfreezePanes);
            this.splitContainerControl1.Panel1.Controls.Add(this.buttonFreezePanes);
            this.splitContainerControl1.Panel1.Controls.Add(this.buttonFreezeColumn);
            this.splitContainerControl1.Panel1.Controls.Add(this.buttonFreezeRow);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.spreadsheetControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(724, 476);
            this.splitContainerControl1.SplitterPosition = 114;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // buttonUnfreezePanes
            // 
            this.buttonUnfreezePanes.Location = new System.Drawing.Point(3, 93);
            this.buttonUnfreezePanes.Name = "buttonUnfreezePanes";
            this.buttonUnfreezePanes.Size = new System.Drawing.Size(110, 23);
            this.buttonUnfreezePanes.TabIndex = 3;
            this.buttonUnfreezePanes.Text = "Unfreeze Panes";
            this.buttonUnfreezePanes.UseVisualStyleBackColor = true;
            this.buttonUnfreezePanes.Click += new System.EventHandler(this.buttonUnfreezePanes_Click);
            // 
            // buttonFreezePanes
            // 
            this.buttonFreezePanes.Location = new System.Drawing.Point(3, 64);
            this.buttonFreezePanes.Name = "buttonFreezePanes";
            this.buttonFreezePanes.Size = new System.Drawing.Size(110, 23);
            this.buttonFreezePanes.TabIndex = 2;
            this.buttonFreezePanes.Text = "Freeze Panes";
            this.buttonFreezePanes.UseVisualStyleBackColor = true;
            this.buttonFreezePanes.Click += new System.EventHandler(this.buttonFreezePanes_Click);
            // 
            // buttonFreezeColumn
            // 
            this.buttonFreezeColumn.Location = new System.Drawing.Point(3, 35);
            this.buttonFreezeColumn.Name = "buttonFreezeColumn";
            this.buttonFreezeColumn.Size = new System.Drawing.Size(110, 23);
            this.buttonFreezeColumn.TabIndex = 1;
            this.buttonFreezeColumn.Text = "Freeze Left Column";
            this.buttonFreezeColumn.UseVisualStyleBackColor = true;
            this.buttonFreezeColumn.Click += new System.EventHandler(this.buttonFreezeColumn_Click);
            // 
            // buttonFreezeRow
            // 
            this.buttonFreezeRow.Location = new System.Drawing.Point(3, 3);
            this.buttonFreezeRow.Name = "buttonFreezeRow";
            this.buttonFreezeRow.Size = new System.Drawing.Size(110, 26);
            this.buttonFreezeRow.TabIndex = 0;
            this.buttonFreezeRow.Text = "Freeze Top Row";
            this.buttonFreezeRow.UseVisualStyleBackColor = true;
            this.buttonFreezeRow.Click += new System.EventHandler(this.buttonFreezeRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 476);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Button buttonFreezeRow;
        private System.Windows.Forms.Button buttonFreezeColumn;
        private System.Windows.Forms.Button buttonFreezePanes;
        private System.Windows.Forms.Button buttonUnfreezePanes;
    }
}

