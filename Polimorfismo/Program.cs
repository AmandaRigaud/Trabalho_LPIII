using System;


namespace Polimorfismo{
    class Program {
        public static void Main(String[] args){
            Calculadora c1 = new Calculadora();

            c1.soma(1,2,4);
            c1.sub(1,2,5);
            c1.sub(1.2,2.4,5.5,6.6);
            c1.mult(2,3,4);
            c1.div(2,3,4);
            c1.mult(2.3,3.4,3.5);
        }
    }
}