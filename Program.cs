using System;

namespace ImcPoo {
    class Program {
        static void Main(string[] args) {

            Imc imc = new Imc();

            Console.WriteLine("|-----------------------|");
            Console.WriteLine("|----Calculadora IMC----|");
            Console.WriteLine("|-----------------------|");

            Console.WriteLine();
            Console.Write("Nome: ");
            imc.Nome = Console.ReadLine();
            Console.Write("Peso: ");
            imc.Peso = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            imc.Altura = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine();
            Console.WriteLine(imc);
            if (imc.Resultado() < 18.5) {
                Console.WriteLine("Abaixo do Peso!");
            }
            else if (imc.Resultado() < 24.9) {
                Console.WriteLine("Peso idel, Parabéns!");
            }
            else if (imc.Resultado() < 29.9) {
                Console.WriteLine("Levemente acima do peso!");
            }
            else if (imc.Resultado() < 34.9) {
                Console.WriteLine("Obsidade grau 1!");
            }
            else if (imc.Resultado() < 39.9) {
                Console.WriteLine("Obsidade grau 2, sereva!");
            }
            else {
                Console.WriteLine("Obsidade 3, mórbida!");
            }
        }
    }
}
