using System;
using Trabalho_LPIII.models;

namespace Polimorfismo {
    public class Program {
        public static void Main(String[] args) {
            Soma soma = new Soma();
            Subtracao subtracao = new Subtracao();
            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();

            Console.WriteLine(soma.eval(1, 2));
            Console.WriteLine(subtracao.eval(4, 1, 1));
            Console.WriteLine(multiplicacao.eval(4, 5, 2));
            Console.WriteLine(divisao.eval(100, 4, 5));
        }
    }
}