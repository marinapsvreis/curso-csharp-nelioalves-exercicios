using System;
using System.Globalization; // Para utilizar o format provider

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá mundo!");

            //Tipos mais usados:
            /*
             * int (inteiros até 4 bytes)
             * long (inteiros até 8 bytes)
             * float (flutuantes até 4 bytes)
             * double (flutuantes até 8 bytes)
             * decimal (flutuantes até 12 bytes)
             * char (uma letra)
             * bool (true / false )   
             * string (conjunto de caracteres) - é imutavel
             * object
             */

            //Overflow é quando um calculo estrapola o limite da variável (vai pro limite oposto)

            //sbyte x = 127;
            //byte x = 255;

            //x++;

            //int x = 1000;
            //long x = 100000009L;
            float x = 4.5f;
            double y = 4.5;
            char teste = 'M';
            string teste2 = "Testando";
            object teste3 = "Tipo object";
            object teste4 = 4.5f;

            int n1 = int.MinValue;
            int n2 = int.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x.ToString("F2")); // escolhendo a quantidade de casas decimais
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture)); // Para imprimir com o . como separador
            Console.WriteLine(teste);
            Console.WriteLine(teste2);
            Console.WriteLine(teste3);
            Console.WriteLine(teste4);
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            //Placeholders, concatenação, interpolação

            string nome = "Marina";
            int idade = 30;
            double saldo = 100.54321;

            //Placeholder
            Console.WriteLine("{0} tem {1} anos e possui R$ {2:F2} de saldo.", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e possui R$ {saldo:F2} de saldo");

            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e possui R$ " + saldo.ToString("F2") + " de saldo");

            //Trocar por ponto
            Console.WriteLine(nome + " tem " + idade + " anos e possui R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " de saldo");

        }
    }
}
