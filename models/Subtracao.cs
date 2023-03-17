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
    }
    
}