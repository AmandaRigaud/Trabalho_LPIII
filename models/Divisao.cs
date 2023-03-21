using System;
using Trabalho_LPIII.interfaces;

namespace Trabalho_LPIII.models
{
    public class Divisao : IOperacoes {
        public Double eval(params Double[] numero) {
            Double resultado = 0;

            resultado = resultado + numero[0];
            for (int i = 1; i<numero.Length; i++) {
                resultado /= numero[i];
            }
            return resultado;
        }

        public Double eval(int start, int end, int step){
            Console.WriteLine("limite");
            Double div = start;
            int count = 0;
            for( int i = start; i>=end;){
                div /= step;
                if(div < end){
                    div *=step;
                    break;
                }
                count++;
                Console.Write("Etapa: {0} = {1} |", count, div);
            }
            Console.WriteLine("");
            return div;
        }
    }
}