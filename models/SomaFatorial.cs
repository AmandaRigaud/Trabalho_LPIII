using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_LPIII.interfaces;
namespace Trabalho_LPIII.models
{
    public class SomaFatorial : IOperacoes {
        public Double eval(params Double[] numero) {

            List<Double> lista = new List<Double>();

            foreach (Double num in numero) {
                if (num == 0 || num == 1) return 1;

                var fat = num * eval(num-1);
                lista.Add(fat);
            }

            Double soma = 0;
            foreach (Double val in lista) {
                soma += val;
            }
            return soma;
        }
    }
}