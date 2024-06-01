namespace ACCOUNTING_APP
{
    partial class Form10
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
            this.button_backfinancialreport = new System.Windows.Forms.Button();
            this.button_jurnalumum = new System.Windows.Forms.Button();
            this.button_bukubesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_backfinancialreport
            // 
            this.button_backfinancialreport.BackColor = System.Drawing.Color.Transparent;
            this.button_backfinancialreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_backfinancialreport.Location = new System.Drawing.Point(15, 22);
            this.button_backfinancialreport.Name = "button_backfinancialreport";
            this.button_backfinancialreport.Size = new System.Drawing.Size(117, 51);
            this.button_backfinancialreport.TabIndex = 11;
            this.button_backfinancialreport.UseVisualStyleBackColor = false;
            this.button_backfinancialreport.Click += new System.EventHandler(this.button_backfinancialreport_Click);
            // 
            // button_jurnalumum
            // 
            this.button_jurnalumum.BackColor = System.Drawing.Color.Transparent;
            this.button_jurnalumum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_jurnalumum.ForeColor = System.Drawing.Color.Transparent;
            this.button_jurnalumum.Location = new System.Drawing.Point(180, 162);
            this.button_jurnalumum.Name = "button_jurnalumum";
            this.button_jurnalumum.Size = new System.Drawing.Size(137, 89);
            this.button_jurnalumum.TabIndex = 12;
            this.button_jurnalumum.UseVisualStyleBackColor = false;
            this.button_jurnalumum.Click += new System.EventHandler(this.button_jurnalumum_Click);
            // 
            // button_bukubesar
            // 
            this.button_bukubesar.BackColor = System.Drawing.Color.Transparent;
            this.button_bukubesar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bukubesar.ForeColor = System.Drawing.Color.Transparent;
            this.button_bukubesar.Location = new System.Drawing.Point(459, 162);
            this.button_bukubesar.Name = "button_bukubesar";
            this.button_bukubesar.Size = new System.Drawing.Size(137, 89);
            this.button_bukubesar.TabIndex = 13;
            this.button_bukubesar.UseVisualStyleBackColor = false;
            this.button_bukubesar.Click += new System.EventHandler(this.button_bukubesar_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ACCOUNTING_APP.Properties.Resources.menulaporankeuangan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 459);
            this.Controls.Add(this.button_bukubesar);
            this.Controls.Add(this.button_jurnalumum);
            this.Controls.Add(this.button_backfinancialreport);
            this.DoubleBuffered = true;
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_backfinancialreport;
        private System.Windows.Forms.Button button_jurnalumum;
        private System.Windows.Forms.Button button_bukubesar;
    }
}