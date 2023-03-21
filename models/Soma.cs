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
    }
}