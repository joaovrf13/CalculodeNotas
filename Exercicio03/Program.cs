using System;
using System.Data;
using System.Globalization;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o seu nome: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite suas três notas: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            


            if (aluno.NotaFinal() >= 60.0) {

                Console.WriteLine("NOTA: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " +aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)+  "PONTOS");
            }



        }
    }
}