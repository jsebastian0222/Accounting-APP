namespace ACCOUNTING_APP
{
    partial class Form8
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
            this.dgv_historitransaksi = new System.Windows.Forms.DataGridView();
            this.button_backhistoritransaksi = new System.Windows.Forms.Button();
            this.cbox_month = new System.Windows.Forms.ComboBox();
            this.cbox_year = new System.Windows.Forms.ComboBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historitransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_historitransaksi
            // 
            this.dgv_historitransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historitransaksi.Location = new System.Drawing.Point(21, 192);
            this.dgv_historitransaksi.Name = "dgv_historitransaksi";
            this.dgv_historitransaksi.RowHeadersWidth = 51;
            this.dgv_historitransaksi.RowTemplate.Height = 24;
            this.dgv_historitransaksi.Size = new System.Drawing.Size(944, 252);
            this.dgv_historitransaksi.TabIndex = 2;
            // 
            // button_backhistoritransaksi
            // 
            this.button_backhistoritransaksi.BackColor = System.Drawing.Color.Transparent;
            this.button_backhistoritransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backhistoritransaksi.Location = new System.Drawing.Point(841, 15);
            this.button_backhistoritransaksi.Name = "button_backhistoritransaksi";
            this.button_backhistoritransaksi.Size = new System.Drawing.Size(115, 53);
            this.button_backhistoritransaksi.TabIndex = 8;
            this.button_backhistoritransaksi.UseVisualStyleBackColor = false;
            this.button_backhistoritransaksi.Click += new System.EventHandler(this.button_backhistoritransaksi_Click);
            // 
            // cbox_month
            // 
            this.cbox_month.FormattingEnabled = true;
            this.cbox_month.Items.AddRange(new object[] {
            "All",
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbox_month.Location = new System.Drawing.Point(92, 92);
            this.cbox_month.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_month.Name = "cbox_month";
            this.cbox_month.Size = new System.Drawing.Size(160, 24);
            this.cbox_month.TabIndex = 9;
            this.cbox_month.SelectedIndexChanged += new System.EventHandler(this.comboBox_month_SelectedIndexChanged);
            // 
            // cbox_year
            // 
            this.cbox_year.FormattingEnabled = true;
            this.cbox_year.Items.AddRange(new object[] {
            "All",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbox_year.Location = new System.Drawing.Point(92, 124);
            this.cbox_year.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_year.Name = "cbox_year";
            this.cbox_year.Size = new System.Drawing.Size(160, 24);
            this.cbox_year.TabIndex = 10;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.LimeGreen;
            this.button_submit.Location = new System.Drawing.Point(288, 95);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(115, 53);
            this.button_submit.TabIndex = 11;
            this.button_submit.Text = "SUBMIT";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Year :";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.messageImage_1701333920028;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.cbox_year);
            this.Controls.Add(this.cbox_month);
            this.Controls.Add(this.button_backhistoritransaksi);
            this.Controls.Add(this.dgv_historitransaksi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historitransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_historitransaksi;
        private System.Windows.Forms.Button button_backhistoritransaksi;
        private System.Windows.Forms.ComboBox cbox_month;
        private System.Windows.Forms.ComboBox cbox_year;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label1;
    }
}