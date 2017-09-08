using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtor_consumidor.Classes
{
    class Consumidor
    {
        private String nome;
        private Buffer bufferCompartilhado;


        public Consumidor(string nome, Buffer bufferCompartilhado)
        {
            this.nome = nome;
            this.bufferCompartilhado = bufferCompartilhado;
        }

        public string Nome { get => nome; }

        public void Consumir()
        {
            throw new Exception();
        }
    }
}
