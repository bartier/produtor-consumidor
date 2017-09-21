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
            new Task(_Consumir).Start();
        }

        Random r = new Random();
        protected  void _Consumir()
        {
            while (true)
            {
                Thread.Sleep(4000);
                if (!bufferCompartilhado.Vazio)
                {
                    Thread.Sleep(700);
                    bufferCompartilhado.Get();
                    this.updateText("Consumidor: consumiu 1\n");
                    this.updateBuffer();
                }

            }
        }
    }
}
