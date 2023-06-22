using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // String - criador,recebe o nome para a variável "texto" ou "Wendell"
            // Adcionar variáveis no meio do texto com concatenação (maneira antiga)
            // ("Texto" + Variável + "Texto" + Variável + "Texto" + Variável + "Texto");

            string criador = "Wendell"; //Texto
            int idade = 18; //Número
            float dinheiro = 2.50f; //Número
            int soma = 52 + 77;  //Da pra somar a variável
            float peso = 64.0f;
            float altura = 1.70f;
            float imc = peso / (altura * altura);
            
            Console.WriteLine($"O resultado é {soma}");

            Console.WriteLine($"Na minha carteira tem {dinheiro}");
            Console.WriteLine("Meu nome é " + criador + " e eu tenho " +  idade + " anos"); //Primeira forma de fazer a concatenação (juntar os textos)
            Console.WriteLine("Minha idade é " + idade);
            // A mesma coisa, só que usando a INTERPOLAÇÃO (moderno)
            Console.WriteLine($"Meu nome é {criador} e eu tenho {idade} anos"); //Segunda forma de fazer a INTERPOLAÇÃO (junção)
            // JUntar o texto com outro se chama CONCATENAÇÃO
            Console.WriteLine("Aula 03 Variáveis"); //Escreve e pula a linha
            Console.WriteLine("Programa criado por " + criador);
            Console.WriteLine("Eu sou o " + criador);
            Console.WriteLine("Lembrando, quem fez foi o " + criador);



            //Console.Write("Meu nome é " + criador);
            //Console.Write(e eu tenho " = idade);
            //ConsoleWriteLine("anos");
        


            Console.Read(); // Trava a Tela
        }
    }
}
