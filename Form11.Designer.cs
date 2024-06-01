namespace ACCOUNTING_APP
{
    partial class Form11
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
            this.button_backbukubesar = new System.Windows.Forms.Button();
            this.label_per = new System.Windows.Forms.Label();
            this.dtp_bukubesar = new System.Windows.Forms.DateTimePicker();
            this.dgv_akunkas = new System.Windows.Forms.DataGridView();
            this.dgv_akunhutang = new System.Windows.Forms.DataGridView();
            this.dgv_akunpendapatan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_akunkas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_akunhutang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_akunpendapatan)).BeginInit();
            this.SuspendLayout();
            // 
            // button_backbukubesar
            // 
            this.button_backbukubesar.BackColor = System.Drawing.Color.Transparent;
            this.button_backbukubesar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backbukubesar.Location = new System.Drawing.Point(12, 12);
            this.button_backbukubesar.Name = "button_backbukubesar";
            this.button_backbukubesar.Size = new System.Drawing.Size(74, 38);
            this.button_backbukubesar.TabIndex = 12;
            this.button_backbukubesar.UseVisualStyleBackColor = false;
            this.button_backbukubesar.Click += new System.EventHandler(this.button_backbukubesar_Click);
            // 
            // label_per
            // 
            this.label_per.AutoSize = true;
            this.label_per.BackColor = System.Drawing.Color.Transparent;
            this.label_per.Location = new System.Drawing.Point(221, 99);
            this.label_per.Name = "label_per";
            this.label_per.Size = new System.Drawing.Size(28, 16);
            this.label_per.TabIndex = 13;
            this.label_per.Text = "Per";
            // 
            // dtp_bukubesar
            // 
            this.dtp_bukubesar.Location = new System.Drawing.Point(258, 97);
            this.dtp_bukubesar.Name = "dtp_bukubesar";
            this.dtp_bukubesar.Size = new System.Drawing.Size(200, 22);
            this.dtp_bukubesar.TabIndex = 14;
            // 
            // dgv_akunkas
            // 
            this.dgv_akunkas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_akunkas.Location = new System.Drawing.Point(22, 204);
            this.dgv_akunkas.Name = "dgv_akunkas";
            this.dgv_akunkas.RowHeadersWidth = 51;
            this.dgv_akunkas.RowTemplate.Height = 24;
            this.dgv_akunkas.Size = new System.Drawing.Size(678, 150);
            this.dgv_akunkas.TabIndex = 15;
            // 
            // dgv_akunhutang
            // 
            this.dgv_akunhutang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_akunhutang.Location = new System.Drawing.Point(22, 413);
            this.dgv_akunhutang.Name = "dgv_akunhutang";
            this.dgv_akunhutang.RowHeadersWidth = 51;
            this.dgv_akunhutang.RowTemplate.Height = 24;
            this.dgv_akunhutang.Size = new System.Drawing.Size(678, 94);
            this.dgv_akunhutang.TabIndex = 16;
            // 
            // dgv_akunpendapatan
            // 
            this.dgv_akunpendapatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_akunpendapatan.Location = new System.Drawing.Point(22, 544);
            this.dgv_akunpendapatan.Name = "dgv_akunpendapatan";
            this.dgv_akunpendapatan.RowHeadersWidth = 51;
            this.dgv_akunpendapatan.RowTemplate.Height = 24;
            this.dgv_akunpendapatan.Size = new System.Drawing.Size(678, 99);
            this.dgv_akunpendapatan.TabIndex = 17;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.bukubesar2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 650);
            this.Controls.Add(this.dgv_akunpendapatan);
            this.Controls.Add(this.dgv_akunhutang);
            this.Controls.Add(this.dgv_akunkas);
            this.Controls.Add(this.dtp_bukubesar);
            this.Controls.Add(this.label_per);
            this.Controls.Add(this.button_backbukubesar);
            this.DoubleBuffered = true;
            this.Name = "Form11";
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_akunkas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_akunhutang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_akunpendapatan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_backbukubesar;
        private System.Windows.Forms.Label label_per;
        private System.Windows.Forms.DateTimePicker dtp_bukubesar;
        private System.Windows.Forms.DataGridView dgv_akunkas;
        private System.Windows.Forms.DataGridView dgv_akunhutang;
        private System.Windows.Forms.DataGridView dgv_akunpendapatan;
    }
}