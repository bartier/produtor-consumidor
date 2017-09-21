﻿using produtor_consumidor.Classes;
using System;
using System.Collections;
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
        public const int TAMANHO_BUFFER = 5;

        Semaphore console = new Semaphore(1, 1); // usado para acessos exclusivos no "console"

        private Classes.Buffer buffer;

        private string valorProduzido; // usado para desenhar no buffer o valor produzido

        private bool simulando; // usado para controle do formulario  
              
        public FrmPrincipal()
        {
            InitializeComponent();

            this.simulando = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (simulando)
            {
                MessageBox.Show("Já iniciou uma simulação!");
                return;
            }

            // inicializa o buffer com 5 posicoes disponiveis conforme
            // o formulario (5 pictureBox's)
            buffer = new Classes.Buffer(TAMANHO_BUFFER);

            Consumidor c = new Consumidor(buffer, EscreverMensagem, AtualizarBuffer);
            Produtor p = new Produtor(buffer, EscreverMensagem, AtualizarBuffer);

            txtMensagens.Text = "";
            EscreverMensagem("Iniciado simulação do produtor e consumidor!\n");
            simulando = true;

            // inicia threads do produtor e consumidor
            p.Produzir();
            c.Consumir();
        }

        private void AtualizarBuffer()
        {
            new Thread(_atualizarBuffer).Start();
        }

        private void _atualizarBuffer()
        {
            //the method will invoke itself on the main thread if it isn't already running there
            if (InvokeRequired)
            {
                //picturebox.WaitOne();
                this.Invoke((MethodInvoker)(() => _atualizarBuffer()));
                //picturebox.Release();
                return;
            }

            for (int i = 0; i < buffer.Tamanho; i++)
            {
                PictureBox pb = ((PictureBox)this.panelBananas.Controls.Find("pb" + i, true)[0]);
                valorProduzido = buffer.ValorDe(i).ToString();

                if (this.buffer.Ocupado(i)) // posicao ocupada tera imagem com banana
                    {
                        pb.Image = Properties.Resources.box_banana_preenchido;

                    }
                    else // imagem sem banana
                    {
                        pb.Image = Properties.Resources.box_banana;
                        
                    }

                pb.Refresh();
            }
         
        }

        public void EscreverMensagem(string mensagem)
        {
            new Thread(() => AtualizarTextBox(txtMensagens, mensagem)).Start();
        }

        private void AtualizarTextBox(TextBox textBox, string conteudo)
        {
            //the method will invoke itself on the main thread if it isn't already running there
            if (InvokeRequired)
            {
                console.WaitOne();
                this.Invoke((MethodInvoker)(() => AtualizarTextBox(textBox, conteudo)));
                console.Release();
                return;
            }       
            
            txtMensagens.AppendText(conteudo);
            Application.DoEvents();
       
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RA: 16174 - Gustavo Ramalho\n RA: 16196 - Vitor Bartier", "Sobre:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("");
        }

        private void btnSalvarLog_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("");
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            if (!simulando)
                return;

            using (Font myFont = new Font("Arial", 14))
            {
                e.Graphics.DrawString((valorProduzido == "0"? "": valorProduzido), myFont, Brushes.Black, new Point(22, 10));
            }
        }
    }
}
