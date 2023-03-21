using System;
using Trabalho_LPIII.interfaces;

namespace Trabalho_LPIII.models
{
    public class Subtracao : IOperacoes {
        public Double eval(params Double[] numero) {
            Double resultado = 0;

            resultado = resultado + numero[0];
            for (int i = 1; i<numero.Length; i++) {
                resultado -= numero[i];
            }
            return resultado;
        }

        public Double eval(int start, int end, int step){
            Double sub = start;
            int count = 0;
            for(int i = end; i <= start;){
                sub -= step;
                if(sub <= end) break;
                count++;
                Console.Write("Etapa: {0} = {1} | ", count, sub);
            }
            Console.WriteLine("");
            return sub;
        }
    }
    
}