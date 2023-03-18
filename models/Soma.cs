using System;
using Trabalho_LPIII.interfaces;

namespace Trabalho_LPIII.models {
    public class Soma : IOperacoes {
        public Double eval(params Double[] numero) {
            Double soma = 0;
            foreach(Double num in numero) {
                soma += num;
            }
            return soma;
        }
       
        public Double eval(int start, int end, int step) {
            Double soma = 0;
            int count = 0;
            for (int i=start; i<=end;) {
                soma += step;
                if (soma > end) break;
                count++;
                Console.Write("Etapa " + count + ": " + soma + " | ");
            }
            Console.WriteLine("");
            return soma;
        }
    }
}