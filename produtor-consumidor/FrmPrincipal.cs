using produtor_consumidor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produtor_consumidor
{
    public partial class FrmPrincipal : Form
    {
        Semaphore console = new Semaphore(1, 1);

        private Consumidor consumidor;
        private Produtor produtor;
        private Classes.Buffer buffer;

        private bool iniciadoSimulacao; // usado para controle do formulario

        public FrmPrincipal()
        {
            InitializeComponent();

            this.iniciadoSimulacao = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (iniciadoSimulacao)
            {
                MessageBox.Show("Já iniciou uma simulação!");
                return;
            }

            // inicializa o buffer com 5 posicoes disponiveis conforme
            // o formulario (5 pictureBox's)
            buffer = new Classes.Buffer(5);

            // Criação do produtor chamando o formulário genérico
            FrmNomeProdutorConsumidor frmGenerico = new FrmNomeProdutorConsumidor("Produtor");

            if (frmGenerico.ShowDialog() == DialogResult.OK)
            {
                string nomeProdutor = frmGenerico.NomeDaEntidade;

                produtor = new Produtor(nomeProdutor, buffer);
            }
            else
            {
                MessageBox.Show("Cancelado simulação!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // Criação do consumidor chamando o formulário genérico
            frmGenerico = new FrmNomeProdutorConsumidor("Consumidor");

            if (frmGenerico.ShowDialog() == DialogResult.OK)
            {
                string nomeConsumidor = frmGenerico.NomeDaEntidade;

                consumidor = new Consumidor(nomeConsumidor, buffer);
            }
            else
            {
                MessageBox.Show("Cancelado simulação!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMensagens.Text = "";
            escreverMensagem(produtor.Nome, "Oi, tudo bem " + consumidor.Nome + "?" + " Irei produzir para você algumas bananas!\n");
            escreverMensagem(consumidor.Nome, "Tudo bem, " + produtor.Nome + "!" + "Estarei no aguardo =)");

            iniciadoSimulacao = true;
            //consumidor.Consumir();
            //produtor.Produzir();

        }

        private void escreverMensagem(string nome, string mensagem)
        {
            string linha = nome + ": " + mensagem;
            
            new Task(() => UpdateTextBoxText(txtMensagens, linha)).Start();
        }

        private void escreverMensagem(string mensagem)
        {
            string linha = mensagem;

            new Task(() => UpdateTextBoxText(txtMensagens, mensagem)).Start();
        }

        private void UpdateTextBoxText(TextBox textBox, string content)
        {
            //the method will invoke itself on the main thread if it isn't already running there
            if (InvokeRequired)
            {
                console.WaitOne();
                this.Invoke((MethodInvoker)(() => UpdateTextBoxText(textBox, content)));
                console.Release();
                return;
            }

            
            for (int i = 0; i < content.Length; i++)
            {
                try
                {
                    txtMensagens.AppendText(content[i].ToString());
                    Application.DoEvents();
                    Thread.Sleep(30);
                }
                catch (Exception)
                { }
            }
            
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Informação...", "Sobre:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
