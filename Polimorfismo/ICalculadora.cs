using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public interface ICalculadora
    {
        // 2 parametros (int)
        void soma(int n1, int n2);
        void sub(int n1, int n2);
        void mult(int n1, int n2);
        void div(int n1, int n2);

        // 2 parametros (double)
        void soma(double n1, double n2);
        void sub(double n1, double n2);
        void mult(double n1, double n2);
        void div(double n1, double n2);

        // {n} parametros (int)
        void soma(params int[]n);
        void sub(params int[]n);
        void mult(params int[]n);

        // {n} parametros (double)
        void soma(params double[]n);
        void sub(params double[]n);
        void mult(params double[]n);
        void div(params double[]n);

        
    }
}