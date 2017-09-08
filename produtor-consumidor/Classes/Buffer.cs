using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtor_consumidor.Classes
{
    class Buffer
    {
        private bool cheio;
        private int[] recursos;
        private int tamanho;

        /// <summary>
        /// Inicializa o buffer com o valor máximo de posições possíveis.
        /// </summary>
        /// <param name="valorMaximo"></param>
        public Buffer(int valorMaximo)
        {
            cheio = false; // inicialmente ele está vazio
            tamanho = 0; // posicoes ocupadas
            recursos = new int[valorMaximo];
        }

        public void Set(int valorProduzido)
        {
            while (!cheio)
            {
                recursos[tamanho++] = valorProduzido;
            }
        }

        public int Get()
        {
            return recursos[tamanho--];

        }
    }
}
