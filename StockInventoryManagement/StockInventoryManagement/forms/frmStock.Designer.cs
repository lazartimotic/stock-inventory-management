namespace StockInventoryManagement.forms
{
    partial class frmStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stockPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stockNumberOfPieces = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stockCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockSelectedItemCb = new System.Windows.Forms.ComboBox();
            this.lvStock = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnRef = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnWoodType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.lvStock);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1242, 904);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stockPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stockNumberOfPieces);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.stockCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stockSelectedItemCb);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 68);
            this.panel1.TabIndex = 7;
            // 
            // stockPrice
            // 
            this.stockPrice.Enabled = false;
            this.stockPrice.Location = new System.Drawing.Point(873, 23);
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Size = new System.Drawing.Size(116, 34);
            this.stockPrice.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(808, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cena:";
            // 
            // stockNumberOfPieces
            // 
            this.stockNumberOfPieces.Enabled = false;
            this.stockNumberOfPieces.Location = new System.Drawing.Point(625, 23);
            this.stockNumberOfPieces.Name = "stockNumberOfPieces";
            this.stockNumberOfPieces.Size = new System.Drawing.Size(152, 34);
            this.stockNumberOfPieces.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Broj komada:";
            // 
            // stockCode
            // 
            this.stockCode.Enabled = false;
            this.stockCode.Location = new System.Drawing.Point(346, 23);
            this.stockCode.Name = "stockCode";
            this.stockCode.Size = new System.Drawing.Size(121, 34);
            this.stockCode.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sifra:";
            // 
            // stockSelectedItemCb
            // 
            this.stockSelectedItemCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stockSelectedItemCb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stockSelectedItemCb.FormattingEnabled = true;
            this.stockSelectedItemCb.Location = new System.Drawing.Point(3, 18);
            this.stockSelectedItemCb.Name = "stockSelectedItemCb";
            this.stockSelectedItemCb.Size = new System.Drawing.Size(213, 36);
            this.stockSelectedItemCb.TabIndex = 12;
            this.stockSelectedItemCb.SelectedIndexChanged += new System.EventHandler(this.stockSelectedItemCb_SelectedIndexChanged_1);
            // 
            // lvStock
            // 
            this.lvStock.AllColumns.Add(this.olvColumnRef);
            this.lvStock.AllColumns.Add(this.olvColumnWoodType);
            this.lvStock.AllColumns.Add(this.olvColumn3);
            this.lvStock.AllowColumnReorder = true;
            this.lvStock.AlternateRowBackColor = System.Drawing.Color.Gainsboro;
            this.lvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lvStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStock.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.lvStock.CellEditTabChangesRows = true;
            this.lvStock.CellEditUseWholeCell = false;
            this.lvStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnRef,
            this.olvColumnWoodType,
            this.olvColumn3});
            this.lvStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvStock.EmptyListMsg = "Stock Empty";
            this.lvStock.EmptyListMsgFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStock.FullRowSelect = true;
            this.lvStock.GridLines = true;
            this.lvStock.HeaderWordWrap = true;
            this.lvStock.HideSelection = false;
            this.lvStock.Location = new System.Drawing.Point(4, 78);
            this.lvStock.Margin = new System.Windows.Forms.Padding(4);
            this.lvStock.Name = "lvStock";
            this.lvStock.OverlayText.Text = "";
            this.lvStock.RenderNonEditableCheckboxesAsDisabled = true;
            this.lvStock.SelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.lvStock.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lvStock.SelectedForeColor = System.Drawing.Color.White;
            this.lvStock.ShowCommandMenuOnRightClick = true;
            this.lvStock.ShowGroups = false;
            this.lvStock.ShowItemToolTips = true;
            this.lvStock.Size = new System.Drawing.Size(1232, 816);
            this.lvStock.TabIndex = 6;
            this.lvStock.TintSortColumn = true;
            this.lvStock.UnfocusedSelectedBackColor = System.Drawing.Color.SteelBlue;
            this.lvStock.UnfocusedSelectedForeColor = System.Drawing.Color.White;
            this.lvStock.UseCompatibleStateImageBehavior = false;
            this.lvStock.UseExplorerTheme = true;
            this.lvStock.UseFilterIndicator = true;
            this.lvStock.UseFiltering = true;
            this.lvStock.UseHotItem = true;
            this.lvStock.UseHyperlinks = true;
            this.lvStock.View = System.Windows.Forms.View.Details;
            // 
            // olvColumnRef
            // 
            this.olvColumnRef.AspectName = "itemCode";
            this.olvColumnRef.IsEditable = false;
            this.olvColumnRef.Text = "Sifra";
            this.olvColumnRef.Width = 104;
            // 
            // olvColumnWoodType
            // 
            this.olvColumnWoodType.AspectName = "itemName";
            this.olvColumnWoodType.IsEditable = false;
            this.olvColumnWoodType.Text = "Ime artikla";
            this.olvColumnWoodType.Width = 184;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "qty";
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "Broj komada";
            this.olvColumn3.Width = 142;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1260, 910);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox stockPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stockNumberOfPieces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stockCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stockSelectedItemCb;
        public BrightIdeasSoftware.ObjectListView lvStock;
        private BrightIdeasSoftware.OLVColumn olvColumnRef;
        private BrightIdeasSoftware.OLVColumn olvColumnWoodType;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
    }
}