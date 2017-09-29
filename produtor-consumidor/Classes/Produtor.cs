using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produtor_consumidor.Classes
{
    /// <summary>
    /// Representação do produtor no problema produtor-consumidor.
    /// </summary>
    public class Produtor
    {
        private Buffer bufferCompartilhado;
        private Action<string> updateText;
        private Action updateBuffer;
        private Thread t_produtor;

        Random r = new Random();
        private bool continuar = true;

        /// <summary>
        /// Instancia um produtor com um buffer compartilhado e o
        /// local onde ele atualizará as informações.
        /// </summary>
        /// <param name="bufferCompartilhado">Buffer compartilhado</param>
        /// <param name="updateText">Usado o método do formulário principal para escrever no "console"</param>
        public Produtor(Buffer bufferCompartilhado, Action<string> updateText, Action updateBuffer)
        {
            this.bufferCompartilhado = bufferCompartilhado;
            this.updateText = updateText;
            this.updateBuffer = updateBuffer;
        }

        /// <summary>
        /// Cria uma Thread com a lógica do produtor
        /// </summary>
        public void Produzir()
        {
            t_produtor = new Thread(_Produzir);
            t_produtor.Start();
        }


        public void _Produzir()
        {
            while (true)
            {
                if (!continuar)
                    break;

                if (!bufferCompartilhado.Cheio)
                {
                    Thread.Sleep(r.Next(200));

                    int valorProduzido = r.Next(1000);

                    bufferCompartilhado.Set(valorProduzido);

                    this.updateText("Produtor: produziu o valor " + valorProduzido + "\n");
                    this.updateBuffer();
                }
            }
        }

        /// <summary>
        /// Para a produção.
        /// </summary>
        public bool Parar()
        {
            continuar = false;
            t_produtor.Join();
            return true;
        }
    }
}
