﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produtor_consumidor.Classes
{
    class Produtor
    {
        private string nome;
        private Buffer bufferCompartilhado;

        /// <summary>
        /// Instancia um produtor com um nome e buffer associado a ele para produção.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="bufferCompartilhado"></param>
        public Produtor(string nome, Buffer bufferCompartilhado)
        {
            this.nome = nome;
            this.bufferCompartilhado = bufferCompartilhado;
        }

        public string Nome { get => nome; }

        public void Produzir()
        {
            // provavel que seja fazer a chamada do método Set do buffer
            throw new Exception();
        }

    }
}