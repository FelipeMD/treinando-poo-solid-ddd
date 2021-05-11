using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*criando objeto*/
            /*new instancia a classe*/
            
            Endereco endereco2 = new Endereco("rua 1", 10);
            
            Pessoa pessoa2 = new Pessoa("felipe", 1, "masculino");
            
            pessoa2.Identificar();
            endereco2.CadastroEndereco();
        }
    }
}