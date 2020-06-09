﻿using System;
using System.Globalization;

namespace ConstruturesAula51
{
    class Produto
    {
        // Encapsulamento da classe p/ nao expor p/ outro arquivo algum atributos ou operacao q possa prejudicar a integridade do produto
        // Convencao da plataforma C# --> quando o ATRIBUTO E PRIVADO, deve comecar com _ exemplo: (_nome)

        private string _nome;
        private double _preco;
        private int _quantidade;

        // Criando um metodo GET p/ o atributo nome:
        public string GetNome()
        {
            return _nome;
        }

        // Criando um metodo SET p/ o atributo nome:

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        // Criando apenas os metodos GET para os atributos (Preco e Quantidade)

            public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0;
        }

        public Produto()
        {

        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
