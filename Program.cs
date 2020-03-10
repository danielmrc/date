using System;

namespace lab2_ex3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, dia2, mes2, ano2;

            date5 d = new date5(30, 10, 2050);

            Console.WriteLine(d.retornaString());

            d.proxDia();
            Console.WriteLine(d.retornaString());

            Console.Write("Entre com um dia da primeira data: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com um mês da primeira data: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com um ano da primeira data: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com um dia da segunda data: ");
            dia2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com um mês da segunda data: ");
            mes2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com um ano da segunda data: ");
            ano2 = Convert.ToInt32(Console.ReadLine());

            if (d.calcDif(dia, mes, ano, dia2, mes2, ano2) == -1)
            {
                Console.WriteLine("Não é possível calcular a distancia de dias. Primeira data menor q a segunda!!");
            }
            else { 
            Console.WriteLine("A diferença de dias de " + d.retornaStringP(dia, mes, ano) + " para " + d.retornaStringP(dia2, mes2, ano2)
                + " é de: " + d.calcDif(dia, mes, ano, dia2, mes2, ano2));
                 }

            Console.WriteLine("O dia no ano da data " + d.retornaString() + " é: " + d.diaA());

            Console.WriteLine("Pressione qualquer tecla...");
            Console.ReadKey();
        
        }
    }
}
