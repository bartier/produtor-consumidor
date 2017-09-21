using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtor_consumidor.Classes
{
    public class Buffer
    {     
        private int[] recursos;
        private int tamanho;

        /// <summary>
        /// Retorna true se o buffer está totalmente cheio. Caso contrário, false.
        /// </summary>
        public bool Cheio
        {
            get
            {
                for (int i = 0; i < recursos.Length; i++)
                    if (recursos[i] == 0)
                        return false;

                return true;
            }
        }

        /// <summary>
        /// Retorna true se o buffer está totalmente vazio. Caso contrário, false.
        /// </summary>
        public bool Vazio
        {
            get
            {
                for (int i = 0; i < recursos.Length; i++)
                    if (recursos[i] != 0)
                        return false;
                return true;
            }
        }

        public int Tamanho
        {
            get
            {
                return tamanho;
            }
        }

        /// <summary>
        /// Retorna true se a posição do buffer estiver ocupada, caso contrário false.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool Ocupado(int i)
        {
            if (recursos[i] != 0)
                return true;

            return false;
        }

        /// <summary>
        /// Inicializa o buffer com o valor máximo de posições possíveis.
        /// </summary>
        /// <param name="valorMaximo">Valor máximo desejado</param>
        public Buffer(int valorMaximo)
        {
            recursos = new int[valorMaximo];
            tamanho = valorMaximo;

            for (int i = 0; i < recursos.Length; i++)
                recursos[i] = 0; // 0 --> posição vazia
                                 // diferente de 0 é posição ocupada
        }

        /// <summary>
        /// Utilizado pelos produtores para inserirem os valores produzidos
        /// </summary>
        /// <param name="valorProduzido"></param>
        public void Set(int valorProduzido)
        {
            for (int i = 0; i < recursos.Length; i++)
            {
                if (recursos[i] == 0)
                {
                    recursos[i] = valorProduzido;
                    break;
                }                   
            }            
        }

        /// <summary>
        /// Utilizado pelos consumidores para consumir os valores
        /// </summary>
        /// <returns></returns>
        public int Get()
        {
            int ret = 0;

            for (int i = recursos.Length - 1; i >= 0; i--)
                if (recursos[i] != 0)
                {
                    ret = recursos[i];
                    recursos[i] = 0;
                    break; 
                }

            return ret;
        }
    }
}
