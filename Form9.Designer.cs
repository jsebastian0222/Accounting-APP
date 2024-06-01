namespace ACCOUNTING_APP
{
    partial class Form9
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
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.cbox_jenispengeluaran = new System.Windows.Forms.ComboBox();
            this.txtbox_namapengeluaran = new System.Windows.Forms.TextBox();
            this.txtbox_jumlahpengeluaran = new System.Windows.Forms.TextBox();
            this.txtbox_hargapengeluaran = new System.Windows.Forms.TextBox();
            this.dgv_inputpengeluaran = new System.Windows.Forms.DataGridView();
            this.button_backinputpengeluaran = new System.Windows.Forms.Button();
            this.button_inputpengeluaran2 = new System.Windows.Forms.Button();
            this.cbox_month = new System.Windows.Forms.ComboBox();
            this.cbox_year = new System.Windows.Forms.ComboBox();
            this.button_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inputpengeluaran)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(45, 168);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(152, 22);
            this.dtp1.TabIndex = 0;
            // 
            // cbox_jenispengeluaran
            // 
            this.cbox_jenispengeluaran.BackColor = System.Drawing.Color.DimGray;
            this.cbox_jenispengeluaran.ForeColor = System.Drawing.Color.White;
            this.cbox_jenispengeluaran.FormattingEnabled = true;
            this.cbox_jenispengeluaran.Items.AddRange(new object[] {
            "Utilitas",
            "Alat dan Bahan",
            "Insiden",
            "Layanan",
            "Lain-Lain"});
            this.cbox_jenispengeluaran.Location = new System.Drawing.Point(217, 171);
            this.cbox_jenispengeluaran.Name = "cbox_jenispengeluaran";
            this.cbox_jenispengeluaran.Size = new System.Drawing.Size(127, 24);
            this.cbox_jenispengeluaran.TabIndex = 1;
            // 
            // txtbox_namapengeluaran
            // 
            this.txtbox_namapengeluaran.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_namapengeluaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_namapengeluaran.ForeColor = System.Drawing.Color.White;
            this.txtbox_namapengeluaran.Location = new System.Drawing.Point(368, 172);
            this.txtbox_namapengeluaran.Name = "txtbox_namapengeluaran";
            this.txtbox_namapengeluaran.Size = new System.Drawing.Size(143, 15);
            this.txtbox_namapengeluaran.TabIndex = 2;
            // 
            // txtbox_jumlahpengeluaran
            // 
            this.txtbox_jumlahpengeluaran.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_jumlahpengeluaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_jumlahpengeluaran.ForeColor = System.Drawing.Color.White;
            this.txtbox_jumlahpengeluaran.Location = new System.Drawing.Point(533, 171);
            this.txtbox_jumlahpengeluaran.Name = "txtbox_jumlahpengeluaran";
            this.txtbox_jumlahpengeluaran.Size = new System.Drawing.Size(123, 15);
            this.txtbox_jumlahpengeluaran.TabIndex = 3;
            // 
            // txtbox_hargapengeluaran
            // 
            this.txtbox_hargapengeluaran.BackColor = System.Drawing.Color.DimGray;
            this.txtbox_hargapengeluaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_hargapengeluaran.ForeColor = System.Drawing.Color.White;
            this.txtbox_hargapengeluaran.Location = new System.Drawing.Point(680, 171);
            this.txtbox_hargapengeluaran.Name = "txtbox_hargapengeluaran";
            this.txtbox_hargapengeluaran.Size = new System.Drawing.Size(123, 15);
            this.txtbox_hargapengeluaran.TabIndex = 4;
            // 
            // dgv_inputpengeluaran
            // 
            this.dgv_inputpengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inputpengeluaran.Location = new System.Drawing.Point(55, 224);
            this.dgv_inputpengeluaran.Name = "dgv_inputpengeluaran";
            this.dgv_inputpengeluaran.RowHeadersWidth = 51;
            this.dgv_inputpengeluaran.RowTemplate.Height = 24;
            this.dgv_inputpengeluaran.Size = new System.Drawing.Size(748, 231);
            this.dgv_inputpengeluaran.TabIndex = 5;
            // 
            // button_backinputpengeluaran
            // 
            this.button_backinputpengeluaran.BackColor = System.Drawing.Color.Transparent;
            this.button_backinputpengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backinputpengeluaran.Location = new System.Drawing.Point(888, 19);
            this.button_backinputpengeluaran.Name = "button_backinputpengeluaran";
            this.button_backinputpengeluaran.Size = new System.Drawing.Size(93, 45);
            this.button_backinputpengeluaran.TabIndex = 10;
            this.button_backinputpengeluaran.UseVisualStyleBackColor = false;
            this.button_backinputpengeluaran.Click += new System.EventHandler(this.button_backinputpengeluaran_Click);
            // 
            // button_inputpengeluaran2
            // 
            this.button_inputpengeluaran2.BackColor = System.Drawing.Color.Transparent;
            this.button_inputpengeluaran2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_inputpengeluaran2.Location = new System.Drawing.Point(843, 157);
            this.button_inputpengeluaran2.Name = "button_inputpengeluaran2";
            this.button_inputpengeluaran2.Size = new System.Drawing.Size(107, 51);
            this.button_inputpengeluaran2.TabIndex = 11;
            this.button_inputpengeluaran2.UseVisualStyleBackColor = false;
            this.button_inputpengeluaran2.Click += new System.EventHandler(this.button_inputpengeluaran2_Click);
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
            this.cbox_month.Location = new System.Drawing.Point(55, 461);
            this.cbox_month.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_month.Name = "cbox_month";
            this.cbox_month.Size = new System.Drawing.Size(160, 24);
            this.cbox_month.TabIndex = 13;
            this.cbox_month.SelectedIndexChanged += new System.EventHandler(this.cbox_month_SelectedIndexChanged);
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
            this.cbox_year.Location = new System.Drawing.Point(232, 462);
            this.cbox_year.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_year.Name = "cbox_year";
            this.cbox_year.Size = new System.Drawing.Size(160, 24);
            this.cbox_year.TabIndex = 14;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.Chartreuse;
            this.button_submit.Location = new System.Drawing.Point(417, 461);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(104, 38);
            this.button_submit.TabIndex = 15;
            this.button_submit.Text = "SUBMIT";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.Screenshot_2023_12_06_082342;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 508);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.cbox_year);
            this.Controls.Add(this.cbox_month);
            this.Controls.Add(this.button_inputpengeluaran2);
            this.Controls.Add(this.button_backinputpengeluaran);
            this.Controls.Add(this.dgv_inputpengeluaran);
            this.Controls.Add(this.txtbox_hargapengeluaran);
            this.Controls.Add(this.txtbox_jumlahpengeluaran);
            this.Controls.Add(this.txtbox_namapengeluaran);
            this.Controls.Add(this.cbox_jenispengeluaran);
            this.Controls.Add(this.dtp1);
            this.DoubleBuffered = true;
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inputpengeluaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.ComboBox cbox_jenispengeluaran;
        private System.Windows.Forms.TextBox txtbox_namapengeluaran;
        private System.Windows.Forms.TextBox txtbox_jumlahpengeluaran;
        private System.Windows.Forms.TextBox txtbox_hargapengeluaran;
        private System.Windows.Forms.DataGridView dgv_inputpengeluaran;
        private System.Windows.Forms.Button button_backinputpengeluaran;
        private System.Windows.Forms.Button button_inputpengeluaran2;
        private System.Windows.Forms.ComboBox cbox_month;
        private System.Windows.Forms.ComboBox cbox_year;
        private System.Windows.Forms.Button button_submit;
    }
}