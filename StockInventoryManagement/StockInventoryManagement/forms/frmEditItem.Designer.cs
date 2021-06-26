namespace StockInventoryManagement.forms
{
    partial class frmEditItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editName = new System.Windows.Forms.TextBox();
            this.editCode = new System.Windows.Forms.TextBox();
            this.editPrice = new System.Windows.Forms.TextBox();
            this.btn_edit_ok = new System.Windows.Forms.Button();
            this.btn_edit_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv artikla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(23, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(23, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena:";
            // 
            // editName
            // 
            this.editName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editName.Location = new System.Drawing.Point(28, 74);
            this.editName.Name = "editName";
            this.editName.Size = new System.Drawing.Size(269, 34);
            this.editName.TabIndex = 3;
            // 
            // editCode
            // 
            this.editCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editCode.Location = new System.Drawing.Point(28, 178);
            this.editCode.Name = "editCode";
            this.editCode.Size = new System.Drawing.Size(183, 34);
            this.editCode.TabIndex = 4;
            // 
            // editPrice
            // 
            this.editPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.editPrice.Location = new System.Drawing.Point(28, 290);
            this.editPrice.Name = "editPrice";
            this.editPrice.Size = new System.Drawing.Size(183, 34);
            this.editPrice.TabIndex = 5;
            // 
            // btn_edit_ok
            // 
            this.btn_edit_ok.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_edit_ok.Location = new System.Drawing.Point(28, 356);
            this.btn_edit_ok.Name = "btn_edit_ok";
            this.btn_edit_ok.Size = new System.Drawing.Size(91, 39);
            this.btn_edit_ok.TabIndex = 6;
            this.btn_edit_ok.Text = "Izmeni";
            this.btn_edit_ok.UseVisualStyleBackColor = true;
            this.btn_edit_ok.Click += new System.EventHandler(this.btn_edit_ok_Click);
            // 
            // btn_edit_cancel
            // 
            this.btn_edit_cancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_edit_cancel.Location = new System.Drawing.Point(205, 356);
            this.btn_edit_cancel.Name = "btn_edit_cancel";
            this.btn_edit_cancel.Size = new System.Drawing.Size(92, 39);
            this.btn_edit_cancel.TabIndex = 7;
            this.btn_edit_cancel.Text = "Otkazi";
            this.btn_edit_cancel.UseVisualStyleBackColor = true;
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 448);
            this.Controls.Add(this.btn_edit_cancel);
            this.Controls.Add(this.btn_edit_ok);
            this.Controls.Add(this.editPrice);
            this.Controls.Add(this.editCode);
            this.Controls.Add(this.editName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditItem";
            this.Text = "frmEditItem";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox editName;
        private System.Windows.Forms.TextBox editCode;
        private System.Windows.Forms.TextBox editPrice;
        private System.Windows.Forms.Button btn_edit_ok;
        private System.Windows.Forms.Button btn_edit_cancel;
    }
}