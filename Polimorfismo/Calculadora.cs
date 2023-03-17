using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Calculadora : ICalculadora
    {
        public void div(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public void div(double n1, double n2)
        {
            throw new NotImplementedException();
        }


        public void div(params double[] n)
        {
            double div = 1;
            foreach(double num in n){
                div /= num;
            }
            Console.WriteLine("A divisão eh: {0} ",div);
        }

        public void mult(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public void mult(double n1, double n2)
        {
            throw new NotImplementedException();
        }


        public void mult(params int[]n) {
            int mult = 1;
            foreach(int num in n){
                mult *= num;
            }
            Console.WriteLine("A multiplicação eh: {0} ",mult);
        }

        public void mult(params double[] n)
        {
            double mult = 1;
            foreach(double num in n){
                mult *= num;
            }
            Console.WriteLine("A multiplicação eh: {0} ",mult);
        }


        public void soma(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public void soma(double n1, double n2)
        {
            throw new NotImplementedException();
        }


        // {n} parametros (int)
        public void soma(params int[]n){
            int soma = 0;
            foreach(int num in n){
                soma += num;
            }
            Console.WriteLine("A soma eh : {0}", soma);
        }

        public void soma(params double[] n)
        {
            double soma = 0;
            foreach(double num in n){
                soma += num;
            }
            Console.WriteLine("A soma eh : {0}", soma);
        }


        public void sub(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public void sub(double n1, double n2)
        {
            throw new NotImplementedException();
        }


        public void sub(params int[]n){
            if(n.Length > 0){
                int sub = n[0];
                for(int i = 1; i < n.Length; i++){
                    sub *= -1;
                    sub -= - n[i];
                }
                Console.WriteLine("A subtração eh : {0}", sub);
            }
        }

        public void sub(params double[] n)
        {
            if(n.Length > 0){
                double sub = n[0];
                
                for(int i = 1; i < n.Length; i++){
                    sub *= -1;
                    sub -= - n[i];
                }
                Console.WriteLine("A subtração eh : {0}", sub);
            }
        }
    }
}