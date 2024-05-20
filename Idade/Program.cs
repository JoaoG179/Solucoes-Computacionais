// crie uma classe Pessoa para armazenar o Nome e Idade do usuario.
// A classe também deve disponibilizar os metodos:
// "checarIdade" armazena a idade indicada pelo usuario e usa caso de exceção para checar se o usuario é maior de 18 anos.
// Permitindo o acesso se for maior de 18 anos, ou negando o acesso se for menor de 18.
// "imprimir" Imprime as informações do usuario (nome e idade).

using Idade;
using System;
class MainClass {
    static void Main(string[]args) {

        string Nome1;
        int Age;

        Console.WriteLine("Qual o seu nome?");
        Nome1 = Console.ReadLine();
        Console.WriteLine("Qual a sua idade?");
        Age = Convert.ToInt32(Console.ReadLine());

        Person pessoa = new Person(Nome1, Age);
        

        pessoa.imprimir();
        pessoa.checarIdade(Age);
    }
}





