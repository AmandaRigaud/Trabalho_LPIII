using System;
using Trabalho_LPIII.interfaces;

namespace Trabalho_LPIII.models
{
    public class Multiplicacao : IOperacoes {
        public Double eval(params Double[] numero) {
            Double resultado = 1;
            foreach(Double num in numero) {
                resultado *= num;
            }
            return resultado;
        }

        public Double eval(int start, int end, int step){
            Double mult = 1;
            int count = 0;
            for (int i = start; i <=end;){
                mult *= step;
                if(mult > end) break;
                count++;
                Console.Write("Etapa: {0} = {1} |", count, mult);
            }
            Console.WriteLine("");
            return mult;
        }
    }
}