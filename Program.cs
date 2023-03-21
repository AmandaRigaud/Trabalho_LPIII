using System;
using Trabalho_LPIII.models;
using Trabalho_LPIII.models.menu;

namespace Polimorfismo {
    public class Program {
        public static void Main(String[] args) {
            Soma soma = new Soma();
            Subtracao subtracao = new Subtracao();
            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();

            SomaFatorial fatorial = new SomaFatorial();

            int flag = 1;

            while(flag != 0)
            {
                Console.WriteLine("\n==== [MENU] ====\n");
                Console.WriteLine("Escolha a operação que deseja realizar: \n");
                Console.WriteLine("[1] = Soma");
                Console.WriteLine("[2] = Subtração");
                Console.WriteLine("[3] = Divisão");
                Console.WriteLine("[4] = Multiplicação");
                Console.WriteLine("[5] = Fatorial");
                Console.WriteLine("");
                Console.WriteLine("[0] = EXIT\n");
                flag = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                MenuOp.Menu(soma, subtracao, multiplicacao, divisao, fatorial, flag);
                
            }

            
            // Console.WriteLine(soma.eval(1, 2));
            // soma.eval(0, 120, 20);
            // Console.WriteLine(subtracao.eval(4, 1, 1));
            // Console.WriteLine(multiplicacao.eval(4, 5, 2));
            // Console.WriteLine(multiplicacao.eval(0, 50, 2));
            // Console.WriteLine(divisao.eval(100, 4, 5));

            // Console.WriteLine(fatorial.eval(3, 3, 4, 4, 5));
        }
    }
}