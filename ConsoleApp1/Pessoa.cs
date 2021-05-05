using System;

namespace ConsoleApp1
{
    /*construtor*/
    public class Pessoa
    {
        public string genero;
        public int idade;
        public string nome;

        /*metodo*/
        public void Identificar()
        {
            /*interpolizacao de string*/
            Console.WriteLine($"Olá, sou o {nome}" +
                              $"tenho {idade} " +
                              $"e sou do sexo {genero}");
        }
    }
}