﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2Vetor
{
    internal class Produtos
    {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;

        }
    }
}
