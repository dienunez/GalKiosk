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
    public partial class Form_Reiniciar : Form
    {
        public Form_Reiniciar()
        {
            InitializeComponent();
        }
//DEFINO BOTON "no" QUE LLAMA AL FORM PRINCIPAL
        private void button_no_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_GalKiosk frm = new Form_GalKiosk();
            frm.Show();
        }
//DEFINO BOTON "SI" QUE REINCIA PC
        private void button_si_Click(object sender, EventArgs e)
        {
            Process r = new Process();
            r.StartInfo.FileName = "cmd.exe";
            r.StartInfo.Arguments = "/c shutdown -r -f -t 0";
            r.StartInfo.UseShellExecute = false;
            r.StartInfo.RedirectStandardOutput = true;
            r.Start();
        }

        private void Form_Reiniciar_Load(object sender, EventArgs e)
        {

        }
    }
}
