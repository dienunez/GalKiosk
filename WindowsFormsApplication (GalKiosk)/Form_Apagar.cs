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
    public partial class Form_Apagar : Form
    {
        public Form_Apagar()
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
//DEFINO BOTON "SI" QUE APAGA PC
        private void button_si_Click(object sender, EventArgs e)
        {
            Process s = new Process();
            s.StartInfo.FileName = "cmd.exe";
            s.StartInfo.Arguments = "/c shutdown -s -f -t 0";
            s.StartInfo.UseShellExecute = false;
            s.StartInfo.RedirectStandardOutput = true;
            s.Start();
        }

        private void Form_Apagar_Load(object sender, EventArgs e)
        {

        }
    }
}
