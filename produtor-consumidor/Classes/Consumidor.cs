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
    /// Representação do consumidor no problema produtor-consumidor
    /// </summary>
    public class Consumidor
    {
        private Buffer bufferCompartilhado;
        private Action<string> updateText;
        private Action updateBuffer;
        private Random r = new Random();

        /// <summary>
        /// Instancia um consumidor com o buffer compartilhado e o
        /// local onde ele atualizará as informações.
        /// </summary>
        /// <param name="bufferCompartilhado">Buffer compartilhado</param>
        /// <param name="updateText">Usado o método do formulário principal para escrever no "console"</param>
        public Consumidor(Buffer bufferCompartilhado, Action<string> updateText, Action updateBuffer)
        {
            this.bufferCompartilhado = bufferCompartilhado;
            this.updateText = updateText;
            this.updateBuffer = updateBuffer;
        }

        /// <summary>
        /// Cria uma Thread com a lógica do consumidor
        /// </summary>
        public void Consumir()
        {
            new Thread(_Consumir).Start();
        }

        protected  void _Consumir()
        {
            while (true)
            {
                if (!bufferCompartilhado.Vazio)
                {
                    Thread.Sleep(r.Next(2000));

                    int valorConsumido = bufferCompartilhado.Get();

                    this.updateText("Consumidor: consumiu o valor " + valorConsumido + "\n");
                    this.updateBuffer();
                }

            }
        }
    }
}
