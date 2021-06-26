﻿namespace StockInventoryManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panLeft = new System.Windows.Forms.Panel();
            this.lvActions = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnAction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panContent = new System.Windows.Forms.Panel();
            this.panBottom = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlblDatabaseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panTop.SuspendLayout();
            this.panLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvActions)).BeginInit();
            this.panBottom.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.SystemColors.Highlight;
            this.panTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panTop.Controls.Add(this.label2);
            this.panTop.Controls.Add(this.label1);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1260, 96);
            this.panTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "MALTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "A. S. TIMBER IMPORTERS";
            // 
            // panLeft
            // 
            this.panLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLeft.Controls.Add(this.lvActions);
            this.panLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeft.Location = new System.Drawing.Point(0, 96);
            this.panLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panLeft.Name = "panLeft";
            this.panLeft.Size = new System.Drawing.Size(254, 773);
            this.panLeft.TabIndex = 1;
            // 
            // lvActions
            // 
            this.lvActions.AllColumns.Add(this.olvColumnAction);
            this.lvActions.AllowColumnReorder = true;
            this.lvActions.AlternateRowBackColor = System.Drawing.Color.Gainsboro;
            this.lvActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvActions.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.lvActions.CellEditTabChangesRows = true;
            this.lvActions.CellEditUseWholeCell = false;
            this.lvActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnAction});
            this.lvActions.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvActions.EmptyListMsg = "- Actions -";
            this.lvActions.EmptyListMsgFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvActions.FullRowSelect = true;
            this.lvActions.GridLines = true;
            this.lvActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvActions.HeaderWordWrap = true;
            this.lvActions.HideSelection = false;
            this.lvActions.Location = new System.Drawing.Point(0, 0);
            this.lvActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvActions.MultiSelect = false;
            this.lvActions.Name = "lvActions";
            this.lvActions.OverlayText.Text = "";
            this.lvActions.RenderNonEditableCheckboxesAsDisabled = true;
            this.lvActions.SelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.lvActions.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lvActions.SelectedForeColor = System.Drawing.Color.White;
            this.lvActions.ShowCommandMenuOnRightClick = true;
            this.lvActions.ShowGroups = false;
            this.lvActions.ShowItemToolTips = true;
            this.lvActions.Size = new System.Drawing.Size(252, 771);
            this.lvActions.TabIndex = 3;
            this.lvActions.TintSortColumn = true;
            this.lvActions.UnfocusedSelectedBackColor = System.Drawing.Color.SteelBlue;
            this.lvActions.UnfocusedSelectedForeColor = System.Drawing.Color.White;
            this.lvActions.UseCompatibleStateImageBehavior = false;
            this.lvActions.UseExplorerTheme = true;
            this.lvActions.UseFilterIndicator = true;
            this.lvActions.UseFiltering = true;
            this.lvActions.UseHotItem = true;
            this.lvActions.UseHyperlinks = true;
            this.lvActions.View = System.Windows.Forms.View.Details;
            this.lvActions.SelectedIndexChanged += new System.EventHandler(this.lvActions_SelectedIndexChanged);
            // 
            // olvColumnAction
            // 
            this.olvColumnAction.AspectName = "title";
            this.olvColumnAction.FillsFreeSpace = true;
            this.olvColumnAction.IsEditable = false;
            this.olvColumnAction.Text = "Page";
            // 
            // panContent
            // 
            this.panContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(254, 96);
            this.panContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1006, 773);
            this.panContent.TabIndex = 2;
            this.panContent.SizeChanged += new System.EventHandler(this.panContent_SizeChanged);
            // 
            // panBottom
            // 
            this.panBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panBottom.Controls.Add(this.statusStrip1);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 869);
            this.panBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1260, 41);
            this.panBottom.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblDatabaseStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1258, 39);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlblDatabaseStatus
            // 
            this.tlblDatabaseStatus.Name = "tlblDatabaseStatus";
            this.tlblDatabaseStatus.Size = new System.Drawing.Size(171, 33);
            this.tlblDatabaseStatus.Text = "No database connected!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1260, 910);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panLeft);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1276, 948);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Inventory Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvActions)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panLeft;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public BrightIdeasSoftware.ObjectListView lvActions;
        private BrightIdeasSoftware.OLVColumn olvColumnAction;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tlblDatabaseStatus;
    }
}