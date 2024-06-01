namespace ACCOUNTING_APP
{
    partial class Form4
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
            this.label_receiptnamaservice = new System.Windows.Forms.Label();
            this.label_receiptharga = new System.Windows.Forms.Label();
            this.label_receipttanggal = new System.Windows.Forms.Label();
            this.lbl_promo = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_receiptnamaservice
            // 
            this.label_receiptnamaservice.AutoSize = true;
            this.label_receiptnamaservice.Location = new System.Drawing.Point(9, 154);
            this.label_receiptnamaservice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_receiptnamaservice.Name = "label_receiptnamaservice";
            this.label_receiptnamaservice.Size = new System.Drawing.Size(75, 12);
            this.label_receiptnamaservice.TabIndex = 0;
            this.label_receiptnamaservice.Text = "Nama service";
            // 
            // label_receiptharga
            // 
            this.label_receiptharga.AutoSize = true;
            this.label_receiptharga.Location = new System.Drawing.Point(201, 154);
            this.label_receiptharga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_receiptharga.Name = "label_receiptharga";
            this.label_receiptharga.Size = new System.Drawing.Size(33, 12);
            this.label_receiptharga.TabIndex = 1;
            this.label_receiptharga.Text = "harga";
            // 
            // label_receipttanggal
            // 
            this.label_receipttanggal.AutoSize = true;
            this.label_receipttanggal.Location = new System.Drawing.Point(90, 80);
            this.label_receipttanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_receipttanggal.Name = "label_receipttanggal";
            this.label_receipttanggal.Size = new System.Drawing.Size(42, 12);
            this.label_receipttanggal.TabIndex = 2;
            this.label_receipttanggal.Text = "tanggal";
            // 
            // lbl_promo
            // 
            this.lbl_promo.AutoSize = true;
            this.lbl_promo.Location = new System.Drawing.Point(235, 251);
            this.lbl_promo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_promo.Name = "lbl_promo";
            this.lbl_promo.Size = new System.Drawing.Size(33, 12);
            this.lbl_promo.TabIndex = 3;
            this.lbl_promo.Text = "harga";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(235, 292);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(33, 12);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "harga";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.receipt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 428);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_promo);
            this.Controls.Add(this.label_receipttanggal);
            this.Controls.Add(this.label_receiptharga);
            this.Controls.Add(this.label_receiptnamaservice);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_receiptnamaservice;
        private System.Windows.Forms.Label label_receiptharga;
        private System.Windows.Forms.Label label_receipttanggal;
        private System.Windows.Forms.Label lbl_promo;
        private System.Windows.Forms.Label lbl_total;
    }
}