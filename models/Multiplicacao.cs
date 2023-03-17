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
    }
}