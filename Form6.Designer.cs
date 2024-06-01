namespace ACCOUNTING_APP
{
    partial class Form6
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
            this.button_backupdatecatalog = new System.Windows.Forms.Button();
            this.button_removeupdatecatalog = new System.Windows.Forms.Button();
            this.button_updateupdatecatalog = new System.Windows.Forms.Button();
            this.cbox_namaserviceupdatecatalog = new System.Windows.Forms.ComboBox();
            this.txtbox_updatenama = new System.Windows.Forms.TextBox();
            this.txtbox_updateharga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_backupdatecatalog
            // 
            this.button_backupdatecatalog.BackColor = System.Drawing.Color.Transparent;
            this.button_backupdatecatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backupdatecatalog.Location = new System.Drawing.Point(18, 13);
            this.button_backupdatecatalog.Name = "button_backupdatecatalog";
            this.button_backupdatecatalog.Size = new System.Drawing.Size(115, 53);
            this.button_backupdatecatalog.TabIndex = 6;
            this.button_backupdatecatalog.UseVisualStyleBackColor = false;
            this.button_backupdatecatalog.Click += new System.EventHandler(this.button_backupdatecatalog_Click);
            // 
            // button_removeupdatecatalog
            // 
            this.button_removeupdatecatalog.BackColor = System.Drawing.Color.Transparent;
            this.button_removeupdatecatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_removeupdatecatalog.Location = new System.Drawing.Point(302, 272);
            this.button_removeupdatecatalog.Name = "button_removeupdatecatalog";
            this.button_removeupdatecatalog.Size = new System.Drawing.Size(115, 53);
            this.button_removeupdatecatalog.TabIndex = 7;
            this.button_removeupdatecatalog.UseVisualStyleBackColor = false;
            // 
            // button_updateupdatecatalog
            // 
            this.button_updateupdatecatalog.BackColor = System.Drawing.Color.Transparent;
            this.button_updateupdatecatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_updateupdatecatalog.Location = new System.Drawing.Point(435, 273);
            this.button_updateupdatecatalog.Name = "button_updateupdatecatalog";
            this.button_updateupdatecatalog.Size = new System.Drawing.Size(115, 53);
            this.button_updateupdatecatalog.TabIndex = 8;
            this.button_updateupdatecatalog.UseVisualStyleBackColor = false;
            // 
            // cbox_namaserviceupdatecatalog
            // 
            this.cbox_namaserviceupdatecatalog.FormattingEnabled = true;
            this.cbox_namaserviceupdatecatalog.Location = new System.Drawing.Point(27, 160);
            this.cbox_namaserviceupdatecatalog.Name = "cbox_namaserviceupdatecatalog";
            this.cbox_namaserviceupdatecatalog.Size = new System.Drawing.Size(188, 24);
            this.cbox_namaserviceupdatecatalog.TabIndex = 9;
            // 
            // txtbox_updatenama
            // 
            this.txtbox_updatenama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_updatenama.Location = new System.Drawing.Point(317, 141);
            this.txtbox_updatenama.Name = "txtbox_updatenama";
            this.txtbox_updatenama.Size = new System.Drawing.Size(220, 15);
            this.txtbox_updatenama.TabIndex = 10;
            // 
            // txtbox_updateharga
            // 
            this.txtbox_updateharga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_updateharga.Location = new System.Drawing.Point(317, 217);
            this.txtbox_updateharga.Name = "txtbox_updateharga";
            this.txtbox_updateharga.Size = new System.Drawing.Size(220, 15);
            this.txtbox_updateharga.TabIndex = 11;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.updatecatalog2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 468);
            this.Controls.Add(this.txtbox_updateharga);
            this.Controls.Add(this.txtbox_updatenama);
            this.Controls.Add(this.cbox_namaserviceupdatecatalog);
            this.Controls.Add(this.button_updateupdatecatalog);
            this.Controls.Add(this.button_removeupdatecatalog);
            this.Controls.Add(this.button_backupdatecatalog);
            this.DoubleBuffered = true;
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_backupdatecatalog;
        private System.Windows.Forms.Button button_removeupdatecatalog;
        private System.Windows.Forms.Button button_updateupdatecatalog;
        private System.Windows.Forms.ComboBox cbox_namaserviceupdatecatalog;
        private System.Windows.Forms.TextBox txtbox_updatenama;
        private System.Windows.Forms.TextBox txtbox_updateharga;
    }
}