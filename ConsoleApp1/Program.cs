﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*criando objeto*/
            /*new instancia a classe*/
            Pessoa pessoa = new Pessoa();
            Endereco endereco = new Endereco();

            endereco.numero = 1;
            endereco.rua = "ruaTeste";

            endereco.CadastroEndereco();
            Pessoa pessoa2 = new Pessoa("felipe", 1, "masculino");
            pessoa2.Identificar();
        }
    }
}