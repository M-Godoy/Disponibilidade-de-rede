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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private async void monitoramento_Tick(object sender, EventArgs e)
        {
            monitoramento.Interval = 10000;

            List<string> Hosts = new List<string> { "stackoverflow.com", "github.com", "microsoft.com"};

            Ping ping = new Ping();

            bool networkAvailable = false;

            try
            {
                // Itera sobre os hosts confiáveis
                foreach (string hostName in Hosts)
                {
                    PingReply reply = await ping.SendPingAsync(hostName);
                    Console.WriteLine($"Ping status for ({hostName}): {reply.Status}");

                    // Verifica se a resposta foi bem-sucedida
                    if (reply.Status == IPStatus.Success)
                    {
                        networkAvailable = true; // Rede está disponível
                        break; // Sai do loop se encontrar um host acessível
                    }
                }
                if (networkAvailable)
                {
                    label4.Text = "A Rede Está Funcionando Normalmente";
                    label4.BackColor = Color.Green;
                }
                else
                {
                    label4.Text = "A Rede Apresenta Problemas";
                    label4.BackColor = Color.Red;
                }
            }
            catch (PingException)
            {
                label4.Text = "Não foi possível alcançar o host";
                label4.BackColor = Color.Orange;
            }
            catch (Exception)
            {
                // Manipulação de exceções gerais
                label4.Text = "Erro ao verificar a rede";
                label4.BackColor = Color.Yellow;
            }
            finally
            {
                ping.Dispose(); // Liberando recursos do objeto Ping
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndesligar_Click(object sender, EventArgs e)
        {
            label3.Text = "A Máquina Está Desligada";
            label3.BackColor = Color.Red;
            label4.Text = "-------";
            label4.BackColor = Color.Transparent;


            monitoramento.Stop();
        }

      

            private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnligar_Click(object sender, EventArgs e)
        {
            label3.Text = "A Máquina Está ligada";
            label3.BackColor = Color.Green;

            monitoramento.Start();

        }
    }
}
