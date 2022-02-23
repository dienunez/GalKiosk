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
    
        public partial class Form_GalKiosk : Form
    {
        public Form_GalKiosk()
        {
            InitializeComponent();
            RefreshStatus();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            timer_hora.Enabled = true;
        }

        private void FormGalKiosk_Load(object sender, EventArgs e)
        {
            
        }

//MUESTRO FECHA, HORA Y NIVEL DE BATERIA
        private void timer_hora_Tick(object sender, EventArgs e)
        {
            label_fechahora.Text = DateTime.Now.ToString();
            RefreshStatus();
        }
//DEFINO BOTON INTERNET EXPLORER
        private void button_iexplore_Click(object sender, EventArgs e)
        {
            ProcessStartInfo browser = new ProcessStartInfo("iexplore.exe");
            browser.WindowStyle = ProcessWindowStyle.Maximized;

            Process b = new Process();
            b.StartInfo = browser;

            b.Start();
        }
//DEFINO BOTON SUSPENDER
        private void button_Suspender_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }
//DEFINO BOTON CERRAR SESION
        private void button_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_CerrarSesion frm = new Form_CerrarSesion();
            frm.Show();
        }
//DEFINO BOTON REINICIAR QUE LLAMA A OTRO FORM
        private void button_Reiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Reiniciar frm = new Form_Reiniciar();
            frm.Show();
        }
//DEFINO BOTON APAGAR QUE LLAMA A OTRO FORM
        private void button_Apagar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Apagar frm = new Form_Apagar();
            frm.Show();
        }
//DEFINO BOTON WIFI
        private void button_Network_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde por favor, esta operación podría tardar unos instantes ...");
            ////////DEFINO VARIABLES LOCALES "wifi", "ssid", "macaddress", "ssidfull", "macaddressfull", "macaddresschar" y "ssidchar"
            string wifi = "Corposuc";
            string ssid = "";
            string macaddress = "";
            string ssidfull = "";
            string macaddressfull = "";
            int macaddresschar = 0;
            int ssidchar = 0;
////////CORRO NETSH PARA SABER SI SE ENCUENTRA CONECTADA AL SSID "Corposuc"
            Process n = new Process();
            n.StartInfo.FileName = "cmd.exe";
            n.StartInfo.Arguments = "/c netsh wlan show interface | findstr /s SSID | findstr /s Corposuc";
            n.StartInfo.UseShellExecute = false;
            n.StartInfo.RedirectStandardOutput = true;
            n.Start();
////////COPIO SALIDA DE NETSH A "ssidfull"
            n.WaitForExit();
            ssidfull = n.StandardOutput.ReadToEnd();
////////PREGUNTO SI LONGITUD DE "ssidfull" ES MAYOR A 10
            if (ssidfull.Length >= 10)
            {
////////////"ssidchar" CONTIENE NUMERO DE UBICACION DE "ssidfull" DONDE ESTA EL PRIMER ": " A PARTIR DE AHI SUMO 2 LUGARES Y COPIO EN "ssid"
                ssidchar = ssidfull.IndexOf(": ");
                ssid = ssidfull.Substring(ssidchar + 2);
            }
            else
            {
                ssid = ssidfull;
            }            
////////CORRO NETSH PARA OBTENER MAC ADDRESS DE PLACA WIFI           
            Process mac = new Process();
            mac.StartInfo.FileName = "cmd.exe";
            mac.StartInfo.Arguments = "/c netsh wlan show interface | findstr /s Direcc";
            mac.StartInfo.UseShellExecute = false;
            mac.StartInfo.RedirectStandardOutput = true;
            mac.Start();
////////COPIO SALIDA DE NETSH A "macaddress"
            mac.WaitForExit();
            macaddressfull = mac.StandardOutput.ReadToEnd();
////////PREGUNTO SI LONGITUD DE "macaddressfull" ES MAYOR A 19
            if (macaddressfull.Length >= 19)
            {
////////////"macaddresschar" CONTIENE NUMERO DE UBICACION DE "macaddressfull" DONDE ESTA EL PRIMER ": " A PARTIR DE AHI SUMO 2 LUGARES Y COPIO EN "macaddress"
                macaddresschar = macaddressfull.IndexOf(": ");
                macaddress = macaddressfull.Substring(macaddresschar + 2);
            }
            else
            {
                macaddress = macaddressfull;
            }
////////PREGUNTO SI "ssid" ES IGUAL A "wifi", EN CASO AFIMRATIVO MUESTRO UN MENSAJE, EN CASO NEGATIVO MUESTRO OTRO MENSAJE
            if (ssid.Trim() == wifi)
            {
                MessageBox.Show("Conectado a CORPOSUC\n" + "Wifi Mac Address: " + macaddress);
            }
            else
            {
                MessageBox.Show("Sin conexión a CORPOSUC, contacte a su administrador\n" + "Wifi Mac Address: " + macaddress);
            }
        }
//DEFINO BOTON MI IP
        private void button_miip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aguarde por favor, esta operación podría tardar unos instantes ...");
            ////////DEFINO VARIABLES LOCALES "ipchar", "ip", "ipfull", "hostnamefull" e "ips"
            int ipchar = 0;
            string ip = "";
            string ipfull = "";
            string hostnamefull = "";
            string[] ips;
////////CORRO IPCONFIG PARA OBTENER IP'S DE RED 
            Process i = new Process();
            i.StartInfo.FileName = "cmd.exe";
            i.StartInfo.Arguments = "/c ipconfig | findstr /s IPv4";
            i.StartInfo.UseShellExecute = false;
            i.StartInfo.RedirectStandardOutput = true;
            i.Start();
////////COPIO SALIDA DE IPCONFIG A "ipfull"
            i.WaitForExit();
            ipfull = i.StandardOutput.ReadToEnd();
////////CORRO IPCONFIG PARA OBTENER HOSTNAME
            Process h = new Process();
            h.StartInfo.FileName = "cmd.exe";
            h.StartInfo.Arguments = "/c hostname";
            h.StartInfo.UseShellExecute = false;
            h.StartInfo.RedirectStandardOutput = true;
            h.Start();
////////COPIO SALIDA DE IPCONFIG A "hostnamefull"
            h.WaitForExit();
            hostnamefull = h.StandardOutput.ReadToEnd();
////////PREGUNTO SI "ipfull" ES IGUAL A "", EN CASO AFIMRATIVO MUESTRO UN MENSAJE, EN CASO NEGATIVO MUESTRO "ip", EN AMBOS INCLUYO "hostnamefull"
            if (ipfull == "")
            {
                MessageBox.Show("Nombre de PC: " + hostnamefull + "\n" + "Direccion IP: No encontrada");
            }
            else
            {
////////////"ipchar" CONTIENE NUMERO DE UBICACION DE "ipfull" DONDE ESTA EL PRIMER ": " A PARTIR DE AHI SUMO 2 LUGARES Y COPIO EN "ip"
                ipchar = ipfull.IndexOf(": ");
                ip = ipfull.Substring(ipchar + 2);
////////////DIVIDO "ip" YA QUE PUEDE CONTENER VARIAS LINEAS Y LUEGO CORTO POR CARACTER "\n", GUARDO EN VECTOR "ips" PERO MUESTRO SOLO PRIMER RESULTADO
                ips = ip.Split('\n');
                MessageBox.Show("Nombre de PC: " + hostnamefull + "\n" + "Direccion IP: " + ips[0]);
            }
        }
//MUESTRO NIVEL DE BATERIA
        private void RefreshStatus()
        {
            PowerStatus power = SystemInformation.PowerStatus;
            float porcentaje = power.BatteryLifePercent;
            string porcentajetexto = porcentaje.ToString("P0");

            if (power.PowerLineStatus == PowerLineStatus.Online)
            {
                if (porcentaje < 1.0f)
                {
                    label_Porcentaje.Text = porcentajetexto;
                    label_Estado.Text = "Estado: Cargando";
                }
                else
                {
                    label_Porcentaje.Text = porcentajetexto;
                    label_Estado.Text = "Estado: Bateria Llena";
                }
            }
            else
            {
                label_Porcentaje.Text = " ";
                label_Estado.Text = "Queda: " + porcentajetexto;
            }
        }
    }
}
