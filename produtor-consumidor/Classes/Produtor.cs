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

        Random r = new Random();

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
            new Task(_Produzir).Start(); 
        }


        public void _Produzir()
        {
            while (true)
            {

                if (!bufferCompartilhado.Cheio)
                {
                    Thread.Sleep(r.Next(2000));
                    bufferCompartilhado.Set(1);
                    this.updateText("Produtor: produziu 1\n");
                    this.updateBuffer();
                }
            }
        }
    }
}
