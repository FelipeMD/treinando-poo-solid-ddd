using System;

namespace ConsoleApp1
{
    /*construtor*/
    public class Pessoa
    {
        public string genero;
        public int idade;
        public string nome;

        /*construtor*/
        public Pessoa()
        {
            nome = "felipe";
            genero = "masculino";
            idade = 2;
        }
        
        /*metodo*/
        public void Identificar()
        {
            /*interpolizacao de string*/
            Console.WriteLine($"Olá, sou o {nome}" +
                              $"tenho {idade} anos " +
                              $"e sou do sexo {genero}");
        }
    }
}