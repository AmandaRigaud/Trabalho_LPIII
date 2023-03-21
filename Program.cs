using System;
using Trabalho_LPIII.models;

namespace Polimorfismo {
    public class Program {
        public static void Main(String[] args) {
            Soma soma = new Soma();
            Subtracao subtracao = new Subtracao();
            Multiplicacao multiplicacao = new Multiplicacao();
            Divisao divisao = new Divisao();

            SomaFatorial fatorial = new SomaFatorial();

            int flag = 1;

            while(flag != 0){
                Console.WriteLine("\n==== [MENU] ====\n");
                Console.WriteLine("Escolha a operação que deseja realizar: \n");
                Console.WriteLine("[1] = Soma");
                Console.WriteLine("[2] = Subtração");
                Console.WriteLine("[3] = Divisão");
                Console.WriteLine("[4] = Multiplicação");
                Console.WriteLine("[5] = Fatorial");
                Console.WriteLine("");
                Console.WriteLine("[0] = EXIT\n");
                flag = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch(flag){
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Desenha realizar Soma Normal[1] ou Soma com Step[2]: ");
                        int op = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if(op == 1){
                            Console.WriteLine("Digite quantidade de valores que deseja Somar: ");
                            int op1 = Convert.ToInt32(Console.ReadLine());
                            if(op1 == 3){
                                Console.WriteLine("\nERRO: Não posivel realizar a soma normal de 3 valores (step)\n");
                                break;
                            }
                            Double[] lista = new Double[op1];
                            for(int i = 0; i < lista.Length; i++){
                                Console.WriteLine("Valor {0}: ",i+1);
                                op1 = Convert.ToInt32(Console.ReadLine());
                                lista[i] = op1;
                            }
                            Console.WriteLine("\nSoma total = "+ soma.eval(lista));
                        }else if(op == 2){
                            Console.WriteLine("Digite o inicio: ");
                            int start = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o final: ");
                            int end = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o step: ");
                            int step = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nStart: {0} | End: {1} | Step: {2}\n",start, end,step);
                            Console.WriteLine("\nSoma total = {0}\n", soma.eval(start,end,step));
                        }
                        break;
                    case 2:
                        Console.WriteLine("Desenha realizar Subtração Normal[1] ou Subtração com Step[2]: ");
                        int op2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if(op2 == 1){
                            Console.WriteLine("Digite quantidade de valores que deseja somar: ");
                            int op1 = Convert.ToInt32(Console.ReadLine());
                            if(op1 == 3){
                                Console.WriteLine("\nERRO: Não posivel realizar a soma normal de 3 valores (step)\n");
                                break;
                            }
                            Double[] lista = new Double[op1];
                            for(int i = 0; i < lista.Length; i++){
                                Console.WriteLine("Valor {0}: ",i+1);
                                op1 = Convert.ToInt32(Console.ReadLine());
                                lista[i] = op1;
                            }
                            Console.WriteLine("\nSubtração total = "+ subtracao.eval(lista));
                        }else if(op2 == 2){
                            Console.WriteLine("Digite o inicio: ");
                            int start = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o final: ");
                            int end = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o step: ");
                            int step = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nStart: {0} | End: {1} | Step: {2}\n",start, end,step);
                            Console.WriteLine("\nSubtração total = {0}\n", subtracao.eval(start,end,step));
                        }
                        break;
                    case 3: 
                        Console.WriteLine("Desenha realizar Divisão Normal[1] ou Divisão com Step[2]: ");
                        int op3 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if(op3 == 1){
                            Console.WriteLine("Digite quantidade de valores que deseja Dividir: ");
                            int op1 = Convert.ToInt32(Console.ReadLine());
                            if(op1 == 3){
                                Console.WriteLine("\nERRO: Não posivel realizar a divisão normal de 3 valores (step)\n");
                                break;
                            }
                            Double[] lista = new Double[op1];
                            for(int i = 0; i < lista.Length; i++){
                                Console.WriteLine("Valor {0}: ",i+1);
                                op1 = Convert.ToInt32(Console.ReadLine());
                                lista[i] = op1;
                            }
                            Console.WriteLine("\nDivisão total = "+ divisao.eval(lista));
                        }else if(op3 == 2){
                            Console.WriteLine("Digite o inicio: ");
                            int start = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o final: ");
                            int end = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o step: ");
                            int step = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nStart: {0} | End: {1} | Step: {2}\n",start, end,step);
                            Console.WriteLine("\nDivisão total = {0}\n", divisao.eval(start,end,step));
                        }
                        break;
                    case 4:
                        Console.WriteLine("Desenha realizar Multiplicação Normal[1] ou Multiplicação com Step[2]: ");
                        int op4 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if(op4 == 1){
                            Console.WriteLine("Digite quantidade de valores que deseja Multiplicar: ");
                            int op1 = Convert.ToInt32(Console.ReadLine());
                            if(op1 == 3){
                                Console.WriteLine("\nERRO: Não posivel realizar a multiplicação normal de 3 valores (step)\n");
                                break;
                            }
                            Double[] lista = new Double[op1];
                            for(int i = 0; i < lista.Length; i++){
                                Console.WriteLine("Valor {0}: ",i+1);
                                op1 = Convert.ToInt32(Console.ReadLine());
                                lista[i] = op1;
                            }
                            Console.WriteLine("\nMultiplicação total = "+ multiplicacao.eval(lista));
                        }else if(op4 == 2){
                            Console.WriteLine("Digite o inicio: ");
                            int start = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o final: ");
                            int end = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o step: ");
                            int step = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nStart: {0} | End: {1} | Step: {2}\n",start, end,step);
                            Console.WriteLine("\nMultiplicação total = {0}\n", multiplicacao.eval(start,end,step));
                        }
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Digite quantidade de valores que deseja o Fatorial: ");
                        int fat = Convert.ToInt32(Console.ReadLine());
                        if(fat == 3){
                            Console.WriteLine("\nERRO: Não posivel realizar a multiplicação normal de 3 valores (step)\n");
                            break;
                        }else{
                            Double[] lista = new Double[fat];
                            for(int i = 0; i < lista.Length; i++){
                                Console.WriteLine("Valor {0}: ",i+1);
                                fat = Convert.ToInt32(Console.ReadLine());
                                lista[i] = fat;
                            }
                            Console.WriteLine("\nSoma Fatorial total = "+ fatorial.eval(lista));
                        }
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }
            // Console.WriteLine(soma.eval(1, 2));
            // soma.eval(0, 120, 20);
            // Console.WriteLine(subtracao.eval(4, 1, 1));
            // Console.WriteLine(multiplicacao.eval(4, 5, 2));
            // Console.WriteLine(multiplicacao.eval(0, 50, 2));
            // Console.WriteLine(divisao.eval(100, 4, 5));

            // Console.WriteLine(fatorial.eval(3, 3, 4, 4, 5));
        }
    }
}