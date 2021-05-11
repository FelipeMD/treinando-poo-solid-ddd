using System;

namespace ConsoleApp1
{
    public class Endereco
    {
        public string rua;
        public int numero;

        public Endereco()
        {
            
        }
        
        public Endereco(string rua, int numero)
        {
            this.rua = rua;
            this.numero = numero;
        }
        
        public void CadastroEndereco()
        {
            Console.WriteLine($"minha rua é {rua} e o numero é {numero}");
        }
    }
}