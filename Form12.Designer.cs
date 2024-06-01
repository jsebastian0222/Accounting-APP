namespace ACCOUNTING_APP
{
    partial class Form12
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
            this.button_backjurnalumum = new System.Windows.Forms.Button();
            this.dgvmoney = new System.Windows.Forms.DataGridView();
            this.cbox_year = new System.Windows.Forms.ComboBox();
            this.cbox_moon = new System.Windows.Forms.ComboBox();
            this.dgvtot = new System.Windows.Forms.DataGridView();
            this.button_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtot)).BeginInit();
            this.SuspendLayout();
            // 
            // button_backjurnalumum
            // 
            this.button_backjurnalumum.BackColor = System.Drawing.Color.Transparent;
            this.button_backjurnalumum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backjurnalumum.Location = new System.Drawing.Point(15, 15);
            this.button_backjurnalumum.Name = "button_backjurnalumum";
            this.button_backjurnalumum.Size = new System.Drawing.Size(84, 44);
            this.button_backjurnalumum.TabIndex = 12;
            this.button_backjurnalumum.UseVisualStyleBackColor = false;
            this.button_backjurnalumum.Click += new System.EventHandler(this.button_backjurnalumum_Click);
            // 
            // dgvmoney
            // 
            this.dgvmoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmoney.Location = new System.Drawing.Point(123, 237);
            this.dgvmoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvmoney.Name = "dgvmoney";
            this.dgvmoney.RowHeadersWidth = 51;
            this.dgvmoney.RowTemplate.Height = 21;
            this.dgvmoney.Size = new System.Drawing.Size(397, 329);
            this.dgvmoney.TabIndex = 13;
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
            "2028"});
            this.cbox_year.Location = new System.Drawing.Point(236, 143);
            this.cbox_year.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_year.Name = "cbox_year";
            this.cbox_year.Size = new System.Drawing.Size(120, 24);
            this.cbox_year.TabIndex = 14;
            this.cbox_year.SelectionChangeCommitted += new System.EventHandler(this.cbox_year_SelectionChangeCommitted);
            // 
            // cbox_moon
            // 
            this.cbox_moon.FormattingEnabled = true;
            this.cbox_moon.Items.AddRange(new object[] {
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
            this.cbox_moon.Location = new System.Drawing.Point(236, 177);
            this.cbox_moon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbox_moon.Name = "cbox_moon";
            this.cbox_moon.Size = new System.Drawing.Size(120, 24);
            this.cbox_moon.TabIndex = 15;
            this.cbox_moon.SelectionChangeCommitted += new System.EventHandler(this.cbox_moon_SelectionChangeCommitted);
            // 
            // dgvtot
            // 
            this.dgvtot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtot.Location = new System.Drawing.Point(123, 568);
            this.dgvtot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvtot.Name = "dgvtot";
            this.dgvtot.RowHeadersWidth = 51;
            this.dgvtot.RowTemplate.Height = 21;
            this.dgvtot.Size = new System.Drawing.Size(397, 113);
            this.dgvtot.TabIndex = 16;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.LawnGreen;
            this.button_submit.Location = new System.Drawing.Point(387, 143);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 44);
            this.button_submit.TabIndex = 17;
            this.button_submit.Text = "SUBMIT";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.labarugi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 717);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.dgvtot);
            this.Controls.Add(this.cbox_moon);
            this.Controls.Add(this.cbox_year);
            this.Controls.Add(this.dgvmoney);
            this.Controls.Add(this.button_backjurnalumum);
            this.DoubleBuffered = true;
            this.Name = "Form12";
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_backjurnalumum;
        private System.Windows.Forms.DataGridView dgvmoney;
        private System.Windows.Forms.ComboBox cbox_year;
        private System.Windows.Forms.ComboBox cbox_moon;
        private System.Windows.Forms.DataGridView dgvtot;
        private System.Windows.Forms.Button button_submit;
    }
}