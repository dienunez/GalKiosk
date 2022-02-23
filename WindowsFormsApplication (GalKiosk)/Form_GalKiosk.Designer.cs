namespace WindowsFormsApplication__GalKiosk_
{
    partial class Form_GalKiosk
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GalKiosk));
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_iexplore = new System.Windows.Forms.Button();
            this.button_Apagar = new System.Windows.Forms.Button();
            this.button_Reiniciar = new System.Windows.Forms.Button();
            this.button_Suspender = new System.Windows.Forms.Button();
            this.button_Network = new System.Windows.Forms.Button();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.groupBox_Power = new System.Windows.Forms.GroupBox();
            this.button_CerrarSesion = new System.Windows.Forms.Button();
            this.groupBox_fechahora = new System.Windows.Forms.GroupBox();
            this.label_fechahora = new System.Windows.Forms.Label();
            this.pictureBox_iexplore = new System.Windows.Forms.PictureBox();
            this.pictureBox_network = new System.Windows.Forms.PictureBox();
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.groupBox_Bateria = new System.Windows.Forms.GroupBox();
            this.label_Estado = new System.Windows.Forms.Label();
            this.label_Porcentaje = new System.Windows.Forms.Label();
            this.pictureBox_miip = new System.Windows.Forms.PictureBox();
            this.button_miip = new System.Windows.Forms.Button();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.groupBox_Power.SuspendLayout();
            this.groupBox_fechahora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iexplore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_network)).BeginInit();
            this.groupBox_general.SuspendLayout();
            this.groupBox_Bateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_miip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.BackgroundImage")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(355, 115);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(125, 33);
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_iexplore
            // 
            this.button_iexplore.BackColor = System.Drawing.SystemColors.Menu;
            this.button_iexplore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_iexplore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_iexplore.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_iexplore.ForeColor = System.Drawing.Color.Black;
            this.button_iexplore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iexplore.Location = new System.Drawing.Point(52, 55);
            this.button_iexplore.Name = "button_iexplore";
            this.button_iexplore.Size = new System.Drawing.Size(180, 40);
            this.button_iexplore.TabIndex = 1;
            this.button_iexplore.Text = "Iniciar Internet Explorer";
            this.button_iexplore.UseVisualStyleBackColor = false;
            this.button_iexplore.Click += new System.EventHandler(this.button_iexplore_Click);
            // 
            // button_Apagar
            // 
            this.button_Apagar.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Apagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Apagar.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_Apagar.ForeColor = System.Drawing.Color.Black;
            this.button_Apagar.Location = new System.Drawing.Point(13, 40);
            this.button_Apagar.Name = "button_Apagar";
            this.button_Apagar.Size = new System.Drawing.Size(100, 40);
            this.button_Apagar.TabIndex = 3;
            this.button_Apagar.Text = "Apagar";
            this.button_Apagar.UseVisualStyleBackColor = false;
            this.button_Apagar.Click += new System.EventHandler(this.button_Apagar_Click);
            // 
            // button_Reiniciar
            // 
            this.button_Reiniciar.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Reiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reiniciar.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_Reiniciar.ForeColor = System.Drawing.Color.Black;
            this.button_Reiniciar.Location = new System.Drawing.Point(133, 40);
            this.button_Reiniciar.Name = "button_Reiniciar";
            this.button_Reiniciar.Size = new System.Drawing.Size(100, 40);
            this.button_Reiniciar.TabIndex = 4;
            this.button_Reiniciar.Text = "Reiniciar";
            this.button_Reiniciar.UseVisualStyleBackColor = false;
            this.button_Reiniciar.Click += new System.EventHandler(this.button_Reiniciar_Click);
            // 
            // button_Suspender
            // 
            this.button_Suspender.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Suspender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Suspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Suspender.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_Suspender.ForeColor = System.Drawing.Color.Black;
            this.button_Suspender.Location = new System.Drawing.Point(373, 40);
            this.button_Suspender.Name = "button_Suspender";
            this.button_Suspender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Suspender.Size = new System.Drawing.Size(100, 40);
            this.button_Suspender.TabIndex = 5;
            this.button_Suspender.Text = "Suspender";
            this.button_Suspender.UseVisualStyleBackColor = false;
            this.button_Suspender.Click += new System.EventHandler(this.button_Suspender_Click);
            // 
            // button_Network
            // 
            this.button_Network.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Network.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Network.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Network.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_Network.ForeColor = System.Drawing.Color.Black;
            this.button_Network.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Network.Location = new System.Drawing.Point(52, 180);
            this.button_Network.Name = "button_Network";
            this.button_Network.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Network.Size = new System.Drawing.Size(180, 40);
            this.button_Network.TabIndex = 6;
            this.button_Network.Text = "Prueba de conexión";
            this.button_Network.UseVisualStyleBackColor = false;
            this.button_Network.Click += new System.EventHandler(this.button_Network_Click);
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Titulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Titulo.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.textBox_Titulo.Location = new System.Drawing.Point(0, 0);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.ReadOnly = true;
            this.textBox_Titulo.Size = new System.Drawing.Size(484, 36);
            this.textBox_Titulo.TabIndex = 7;
            this.textBox_Titulo.TabStop = false;
            this.textBox_Titulo.Text = "Bienvenido a su puesto";
            this.textBox_Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_Power
            // 
            this.groupBox_Power.Controls.Add(this.button_CerrarSesion);
            this.groupBox_Power.Controls.Add(this.groupBox_fechahora);
            this.groupBox_Power.Controls.Add(this.button_Apagar);
            this.groupBox_Power.Controls.Add(this.button_Suspender);
            this.groupBox_Power.Controls.Add(this.button_Reiniciar);
            this.groupBox_Power.Controls.Add(this.pictureBox_Logo);
            this.groupBox_Power.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox_Power.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox_Power.Location = new System.Drawing.Point(-1, 310);
            this.groupBox_Power.Name = "groupBox_Power";
            this.groupBox_Power.Size = new System.Drawing.Size(486, 153);
            this.groupBox_Power.TabIndex = 8;
            this.groupBox_Power.TabStop = false;
            this.groupBox_Power.Text = "Inicio / Apagado de PC";
            // 
            // button_CerrarSesion
            // 
            this.button_CerrarSesion.BackColor = System.Drawing.SystemColors.Menu;
            this.button_CerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CerrarSesion.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_CerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.button_CerrarSesion.Location = new System.Drawing.Point(253, 40);
            this.button_CerrarSesion.Name = "button_CerrarSesion";
            this.button_CerrarSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_CerrarSesion.Size = new System.Drawing.Size(100, 40);
            this.button_CerrarSesion.TabIndex = 15;
            this.button_CerrarSesion.Text = "Cerrar Sesión";
            this.button_CerrarSesion.UseVisualStyleBackColor = false;
            this.button_CerrarSesion.Click += new System.EventHandler(this.button_CerrarSesion_Click);
            // 
            // groupBox_fechahora
            // 
            this.groupBox_fechahora.Controls.Add(this.label_fechahora);
            this.groupBox_fechahora.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox_fechahora.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox_fechahora.Location = new System.Drawing.Point(-7, 100);
            this.groupBox_fechahora.Name = "groupBox_fechahora";
            this.groupBox_fechahora.Size = new System.Drawing.Size(367, 48);
            this.groupBox_fechahora.TabIndex = 14;
            this.groupBox_fechahora.TabStop = false;
            this.groupBox_fechahora.Text = "Fecha y Hora";
            // 
            // label_fechahora
            // 
            this.label_fechahora.AutoSize = true;
            this.label_fechahora.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fechahora.ForeColor = System.Drawing.Color.Black;
            this.label_fechahora.Location = new System.Drawing.Point(13, 18);
            this.label_fechahora.Name = "label_fechahora";
            this.label_fechahora.Size = new System.Drawing.Size(99, 24);
            this.label_fechahora.TabIndex = 13;
            this.label_fechahora.Text = "FechaHora";
            // 
            // pictureBox_iexplore
            // 
            this.pictureBox_iexplore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_iexplore.BackgroundImage")));
            this.pictureBox_iexplore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_iexplore.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_iexplore.Location = new System.Drawing.Point(6, 55);
            this.pictureBox_iexplore.Name = "pictureBox_iexplore";
            this.pictureBox_iexplore.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_iexplore.TabIndex = 9;
            this.pictureBox_iexplore.TabStop = false;
            // 
            // pictureBox_network
            // 
            this.pictureBox_network.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_network.BackgroundImage")));
            this.pictureBox_network.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_network.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_network.Location = new System.Drawing.Point(6, 180);
            this.pictureBox_network.Name = "pictureBox_network";
            this.pictureBox_network.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_network.TabIndex = 11;
            this.pictureBox_network.TabStop = false;
            // 
            // groupBox_general
            // 
            this.groupBox_general.Controls.Add(this.groupBox_Bateria);
            this.groupBox_general.Controls.Add(this.pictureBox_miip);
            this.groupBox_general.Controls.Add(this.button_miip);
            this.groupBox_general.Controls.Add(this.pictureBox_network);
            this.groupBox_general.Controls.Add(this.pictureBox_iexplore);
            this.groupBox_general.Controls.Add(this.button_iexplore);
            this.groupBox_general.Controls.Add(this.button_Network);
            this.groupBox_general.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox_general.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox_general.Location = new System.Drawing.Point(-1, 46);
            this.groupBox_general.Name = "groupBox_general";
            this.groupBox_general.Size = new System.Drawing.Size(486, 258);
            this.groupBox_general.TabIndex = 12;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "Seleccione una opción";
            // 
            // groupBox_Bateria
            // 
            this.groupBox_Bateria.Controls.Add(this.label_Estado);
            this.groupBox_Bateria.Controls.Add(this.label_Porcentaje);
            this.groupBox_Bateria.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox_Bateria.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox_Bateria.Location = new System.Drawing.Point(288, 180);
            this.groupBox_Bateria.Name = "groupBox_Bateria";
            this.groupBox_Bateria.Size = new System.Drawing.Size(164, 63);
            this.groupBox_Bateria.TabIndex = 15;
            this.groupBox_Bateria.TabStop = false;
            this.groupBox_Bateria.Text = "Batería";
            // 
            // label_Estado
            // 
            this.label_Estado.AutoSize = true;
            this.label_Estado.Font = new System.Drawing.Font("Calibri", 11F);
            this.label_Estado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_Estado.Location = new System.Drawing.Point(6, 41);
            this.label_Estado.Name = "label_Estado";
            this.label_Estado.Size = new System.Drawing.Size(49, 18);
            this.label_Estado.TabIndex = 1;
            this.label_Estado.Text = "Estado";
            // 
            // label_Porcentaje
            // 
            this.label_Porcentaje.AutoSize = true;
            this.label_Porcentaje.Font = new System.Drawing.Font("Calibri", 11F);
            this.label_Porcentaje.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_Porcentaje.Location = new System.Drawing.Point(6, 23);
            this.label_Porcentaje.Name = "label_Porcentaje";
            this.label_Porcentaje.Size = new System.Drawing.Size(19, 18);
            this.label_Porcentaje.TabIndex = 0;
            this.label_Porcentaje.Text = "%";
            // 
            // pictureBox_miip
            // 
            this.pictureBox_miip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_miip.BackgroundImage")));
            this.pictureBox_miip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_miip.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_miip.Location = new System.Drawing.Point(6, 117);
            this.pictureBox_miip.Name = "pictureBox_miip";
            this.pictureBox_miip.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_miip.TabIndex = 13;
            this.pictureBox_miip.TabStop = false;
            // 
            // button_miip
            // 
            this.button_miip.BackColor = System.Drawing.SystemColors.Menu;
            this.button_miip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_miip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_miip.Font = new System.Drawing.Font("Calibri", 11F);
            this.button_miip.ForeColor = System.Drawing.Color.Black;
            this.button_miip.Location = new System.Drawing.Point(52, 117);
            this.button_miip.Name = "button_miip";
            this.button_miip.Size = new System.Drawing.Size(180, 40);
            this.button_miip.TabIndex = 12;
            this.button_miip.Text = "Mi IP";
            this.button_miip.UseVisualStyleBackColor = false;
            this.button_miip.Click += new System.EventHandler(this.button_miip_Click);
            // 
            // timer_hora
            // 
            this.timer_hora.Tick += new System.EventHandler(this.timer_hora_Tick);
            // 
            // Form_GalKiosk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox_general);
            this.Controls.Add(this.groupBox_Power);
            this.Controls.Add(this.textBox_Titulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_GalKiosk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GalKiosk v1.0";
            this.Load += new System.EventHandler(this.FormGalKiosk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.groupBox_Power.ResumeLayout(false);
            this.groupBox_fechahora.ResumeLayout(false);
            this.groupBox_fechahora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iexplore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_network)).EndInit();
            this.groupBox_general.ResumeLayout(false);
            this.groupBox_Bateria.ResumeLayout(false);
            this.groupBox_Bateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_miip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_iexplore;
        private System.Windows.Forms.Button button_Apagar;
        private System.Windows.Forms.Button button_Reiniciar;
        private System.Windows.Forms.Button button_Suspender;
        private System.Windows.Forms.Button button_Network;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.GroupBox groupBox_Power;
        private System.Windows.Forms.PictureBox pictureBox_iexplore;
        private System.Windows.Forms.PictureBox pictureBox_network;
        private System.Windows.Forms.GroupBox groupBox_general;
        private System.Windows.Forms.Button button_miip;
        private System.Windows.Forms.PictureBox pictureBox_miip;
        private System.Windows.Forms.Label label_fechahora;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.GroupBox groupBox_fechahora;
        private System.Windows.Forms.Button button_CerrarSesion;
        private System.Windows.Forms.GroupBox groupBox_Bateria;
        private System.Windows.Forms.Label label_Estado;
        private System.Windows.Forms.Label label_Porcentaje;
    }
}

