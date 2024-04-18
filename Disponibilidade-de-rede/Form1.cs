using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disponibilidade_de_rede
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            static void OnNetworkAddressChanged(object sender, EventArgs args)
            {
                foreach ((string name, OperationalStatus status) in
                    NetworkInterface.GetAllNetworkInterfaces()
                        .Select(networkInterface =>
                            (networkInterface.Name, networkInterface.OperationalStatus)))
                {
                    Console.WriteLine(
                        $"{name} is {status}");
                }
            }

        private void monitoramento_Tick(object sender, EventArgs e)
        {

        }
        
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
             Ping ping = new Ping();

            string hostName = "stackoverflow.com";
            PingReply reply = await ping.SendPingAsync(hostName);
            Console.WriteLine($"Ping status for ({hostName}): {reply.Status}");
            if ( reply.Status ==  IPStatus.Success )
            {
                textBox1.BackColor = Color.Green;    
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndesligar_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Transparent;
            textBox2.BackColor = Color.Red;
        }
    }
}
