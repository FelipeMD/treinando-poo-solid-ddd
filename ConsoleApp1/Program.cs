using System;

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

            pessoa.nome = "teste";
            pessoa.idade = 2;
            pessoa.genero = "seila";
            
            pessoa.Identificar();
            endereco.CadastroEndereco();
        }
    }
}