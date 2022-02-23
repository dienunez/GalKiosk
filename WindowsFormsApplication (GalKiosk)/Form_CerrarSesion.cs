using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication__GalKiosk_
{
    public partial class Form_CerrarSesion : Form
    {
        public Form_CerrarSesion()
        {
            InitializeComponent();
        }
//DEFINO BOTON "NO" QUE LLAMA AL FORM PRINCIPAL
        private void button_no_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_GalKiosk frm = new Form_GalKiosk();
            frm.Show();
        }
//DEFINO BOTON "SI" QUE CIERRA SESION
        private void button_si_Click(object sender, EventArgs e)
        {
            Process l = new Process();
            l.StartInfo.FileName = "cmd.exe";
            l.StartInfo.Arguments = "/c shutdown -l";
            l.StartInfo.UseShellExecute = false;
            l.StartInfo.RedirectStandardOutput = true;
            l.Start();
        }
        private void Form_CerrarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
