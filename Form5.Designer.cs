namespace ACCOUNTING_APP
{
    partial class Form5
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
            this.dgv_addcatalog = new System.Windows.Forms.DataGridView();
            this.txtbox_namaserviceaddcatalog = new System.Windows.Forms.TextBox();
            this.txtbox_hargaaddcatalog = new System.Windows.Forms.TextBox();
            this.button_backaddcatalog = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_del = new Sales_and_Finance_Application.Aesthetic.REButton();
            this.btn_add = new Sales_and_Finance_Application.Aesthetic.REButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addcatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_addcatalog
            // 
            this.dgv_addcatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addcatalog.Location = new System.Drawing.Point(21, 99);
            this.dgv_addcatalog.Name = "dgv_addcatalog";
            this.dgv_addcatalog.RowHeadersWidth = 51;
            this.dgv_addcatalog.RowTemplate.Height = 24;
            this.dgv_addcatalog.Size = new System.Drawing.Size(483, 384);
            this.dgv_addcatalog.TabIndex = 0;
            this.dgv_addcatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addcatalog_CellClick);
            this.dgv_addcatalog.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addcatalog_CellValueChanged);
            // 
            // txtbox_namaserviceaddcatalog
            // 
            this.txtbox_namaserviceaddcatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_namaserviceaddcatalog.Location = new System.Drawing.Point(705, 163);
            this.txtbox_namaserviceaddcatalog.Name = "txtbox_namaserviceaddcatalog";
            this.txtbox_namaserviceaddcatalog.Size = new System.Drawing.Size(237, 15);
            this.txtbox_namaserviceaddcatalog.TabIndex = 1;
            // 
            // txtbox_hargaaddcatalog
            // 
            this.txtbox_hargaaddcatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_hargaaddcatalog.Location = new System.Drawing.Point(705, 273);
            this.txtbox_hargaaddcatalog.Name = "txtbox_hargaaddcatalog";
            this.txtbox_hargaaddcatalog.Size = new System.Drawing.Size(237, 15);
            this.txtbox_hargaaddcatalog.TabIndex = 2;
            // 
            // button_backaddcatalog
            // 
            this.button_backaddcatalog.BackColor = System.Drawing.Color.Transparent;
            this.button_backaddcatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backaddcatalog.Location = new System.Drawing.Point(23, 20);
            this.button_backaddcatalog.Name = "button_backaddcatalog";
            this.button_backaddcatalog.Size = new System.Drawing.Size(115, 53);
            this.button_backaddcatalog.TabIndex = 5;
            this.button_backaddcatalog.UseVisualStyleBackColor = false;
            this.button_backaddcatalog.Click += new System.EventHandler(this.button_backaddcatalog_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(757, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 84);
            this.panel2.TabIndex = 8;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.Red;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_del.ForeColor = System.Drawing.Color.White;
            this.btn_del.Location = new System.Drawing.Point(757, 393);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(135, 48);
            this.btn_del.TabIndex = 9;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(757, 337);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(135, 48);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.addcatalog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 508);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.button_backaddcatalog);
            this.Controls.Add(this.txtbox_hargaaddcatalog);
            this.Controls.Add(this.txtbox_namaserviceaddcatalog);
            this.Controls.Add(this.dgv_addcatalog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addcatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_addcatalog;
        private System.Windows.Forms.TextBox txtbox_namaserviceaddcatalog;
        private System.Windows.Forms.TextBox txtbox_hargaaddcatalog;
        private System.Windows.Forms.Button button_backaddcatalog;
        private Sales_and_Finance_Application.Aesthetic.REButton btn_add;
        private System.Windows.Forms.Panel panel2;
        private Sales_and_Finance_Application.Aesthetic.REButton btn_del;
    }
}