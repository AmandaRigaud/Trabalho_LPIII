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

        public void div(decimal n1, decimal n2)
        {
            throw new NotImplementedException();
        }

        public void div(params int[] n)
        {
            throw new NotImplementedException();
        }

        public void div(params double[] n)
        {
            throw new NotImplementedException();
        }

        public void div(params decimal[] n)
        {
            throw new NotImplementedException();
        }

        public void mult(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public void mult(double n1, double n2)
        {
            throw new NotImplementedException();
        }

        public void mult(decimal n1, decimal n2)
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
            throw new NotImplementedException();
        }

        public void mult(params decimal[] n)
        {
            throw new NotImplementedException();
        }

        public void soma(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public void soma(double n1, double n2)
        {
            throw new NotImplementedException();
        }

        public void soma(decimal n1, decimal n2)
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
            throw new NotImplementedException();
        }

        public void soma(params decimal[] n)
        {
            throw new NotImplementedException();
        }

        public void sub(int n1, int n2)
        {
            throw new NotImplementedException();
        }

        public void sub(double n1, double n2)
        {
            throw new NotImplementedException();
        }

        public void sub(decimal n1, decimal n2)
        {
            throw new NotImplementedException();
        }

        public void sub(params int[]n){
            if(n.Length > 0){
                int sub = n[0];
                Console.WriteLine(sub);
                for(int i = 1; i < n.Length; i++){
                    sub *= -1;
                    sub -= - n[i];
                }
                Console.WriteLine("A subtração eh : {0}", sub);
            }
        }

        public void sub(params double[] n)
        {
            throw new NotImplementedException();
        }

        public void sub(params decimal[] n)
        {
            throw new NotImplementedException();
        }

    }
}