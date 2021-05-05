using System;

namespace ConsoleApp1
{
    /*construtor*/
    public class Pessoa
    {
        public string genero;
        public int idade;
        public string nome;

        /*construtor com parametro*/
        // public Pessoa()
        // {
        //     nome = "felipe";
        //     genero = "masculino";
        //     idade = 2;
        // }

        /*construtor vazio*/
        public Pessoa()
        {
            
        }
        
        /*construtor sem parametro*/
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
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