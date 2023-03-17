using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Calculadora : ICalculadora
    {
        public Calculadora(){}

        // 2 parametros (int)
        void soma(int n1, int n2){}
        void sub(int n1, int n2){}
        void mult(int n1, int n2){}
        void div(int n1, int n2){}

        // 2 parametros (double)
        void soma(double n1, double n2){}
        void sub(double n1, double n2){}
        void mult(double n1, double n2){}
        void div(double n1, double n2){}

        // 2 parametros (decimal)
        void soma(decimal n1, decimal n2){}
        void sub(decimal n1, decimal n2){}
        void mult(decimal n1, decimal n2){}
        void div(decimal n1, decimal n2){}
        
        // {n} parametros (int)
        public void soma(params int[]n){
            int soma = 0;
            foreach(int num in n){
                soma += num;
            }
            Console.WriteLine("A soma eh : {0}", soma);
        }
        public void sub(params int[]n){
            if(n.Length > 0){
                int sub = n[0];
                for(int i = 1; i < n.Length; i++){
                    sub -= n[i];
                }
                Console.WriteLine("A subtração eh : {0}", sub);
            }
        }
        public void mult(params int[]n){}
        public void div(params int[]n){}

        // {n} parametros (double)
        public void soma(params double[]n){}
        public void sub(params double[]n){}
        public void mult(params double[]n){}
        public void div(params double[]n){}


        // {n} parametros (decimal)
        public void soma(params decimal[]n){}
        public void sub(params decimal[]n){}
        public void mult(params decimal[]n){}
        public void div(params decimal[]n){}
    }
}