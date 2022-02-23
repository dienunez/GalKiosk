namespace WindowsFormsApplication__GalKiosk_
{
    partial class Form_Apagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Apagar));
            this.button_no = new System.Windows.Forms.Button();
            this.button_si = new System.Windows.Forms.Button();
            this.textBox_apagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_no
            // 
            this.button_no.BackColor = System.Drawing.SystemColors.Menu;
            this.button_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_no.ForeColor = System.Drawing.Color.Black;
            this.button_no.Location = new System.Drawing.Point(147, 45);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(90, 30);
            this.button_no.TabIndex = 17;
            this.button_no.Text = "NO";
            this.button_no.UseVisualStyleBackColor = false;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            // 
            // button_si
            // 
            this.button_si.BackColor = System.Drawing.SystemColors.Menu;
            this.button_si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_si.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_si.ForeColor = System.Drawing.Color.Black;
            this.button_si.Location = new System.Drawing.Point(12, 45);
            this.button_si.Name = "button_si";
            this.button_si.Size = new System.Drawing.Size(90, 30);
            this.button_si.TabIndex = 16;
            this.button_si.Text = "SI";
            this.button_si.UseVisualStyleBackColor = false;
            this.button_si.Click += new System.EventHandler(this.button_si_Click);
            // 
            // textBox_apagar
            // 
            this.textBox_apagar.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_apagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_apagar.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_apagar.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBox_apagar.Location = new System.Drawing.Point(13, 13);
            this.textBox_apagar.Name = "textBox_apagar";
            this.textBox_apagar.ReadOnly = true;
            this.textBox_apagar.Size = new System.Drawing.Size(225, 18);
            this.textBox_apagar.TabIndex = 15;
            this.textBox_apagar.TabStop = false;
            this.textBox_apagar.Text = "¿ Está seguro que desea Apagar ?";
            this.textBox_apagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_Apagar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(251, 89);
            this.ControlBox = false;
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_si);
            this.Controls.Add(this.textBox_apagar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Calibri", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Apagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GalKiosk v1.0";
            this.Load += new System.EventHandler(this.Form_Apagar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Button button_si;
        private System.Windows.Forms.TextBox textBox_apagar;
    }
}