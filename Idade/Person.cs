using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    public class Person
    {
        //variaveis
        private string firstname;
        private int age;

        //construtor
        public Person(string firstName, int age)
        {
            this.Nome1 = firstName;
            this.Age = age;
        }

        //get set
        public string Nome1
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //metodos
        public void imprimir()
        {
            Console.WriteLine("Nome: " + this.Nome1);
            Console.WriteLine("Idade: " + this.Age);
            
        }
        public void checarIdade(int Age)
        {
            {
                if (Age < 18)
               {
                    throw new ArithmeticException("Acesso negado - Você não é maior de 18.");
                }
                else
                {
                    Console.WriteLine("Acesso permitido - Você é maior de 18");
                }
            }
        }
    }

}
