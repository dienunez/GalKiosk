namespace WindowsFormsApplication__GalKiosk_
{
    partial class Form_CerrarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CerrarSesion));
            this.button_no = new System.Windows.Forms.Button();
            this.button_si = new System.Windows.Forms.Button();
            this.textBox_cerrarsesion = new System.Windows.Forms.TextBox();
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
            this.button_no.TabIndex = 20;
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
            this.button_si.TabIndex = 19;
            this.button_si.Text = "SI";
            this.button_si.UseVisualStyleBackColor = false;
            this.button_si.Click += new System.EventHandler(this.button_si_Click);
            // 
            // textBox_cerrarsesion
            // 
            this.textBox_cerrarsesion.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_cerrarsesion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_cerrarsesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_cerrarsesion.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBox_cerrarsesion.Location = new System.Drawing.Point(2, 12);
            this.textBox_cerrarsesion.Name = "textBox_cerrarsesion";
            this.textBox_cerrarsesion.ReadOnly = true;
            this.textBox_cerrarsesion.Size = new System.Drawing.Size(248, 18);
            this.textBox_cerrarsesion.TabIndex = 18;
            this.textBox_cerrarsesion.TabStop = false;
            this.textBox_cerrarsesion.Text = "¿ Está seguro que desea Cerrar Sesión ?";
            this.textBox_cerrarsesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_CerrarSesion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(251, 89);
            this.ControlBox = false;
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.button_si);
            this.Controls.Add(this.textBox_cerrarsesion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Calibri", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_CerrarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GalKiosk v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.Button button_si;
        private System.Windows.Forms.TextBox textBox_cerrarsesion;
    }
}