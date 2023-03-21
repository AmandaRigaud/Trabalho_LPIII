using Trabalho_LPIII.interfaces;

namespace Trabalho_LPIII.models.menu
{
    public static class MenuOp
    {
        public static void Menu(int flag)
            {
                IOperacoes operacao;

                switch (flag)
                {
                    case 0:
                        break;
                    case 1:
                            operacao = new Soma();

                            Console.Clear();
                            Console.Write("Digite quantidade de valores que deseja Somar: ");
                            int op1 = Convert.ToInt32(Console.ReadLine());
                          
                            Double[] lista = new Double[op1];
                            for (int i = 0; i < lista.Length; i++)
                            {
                                Console.Write("Valor {0}: ", i + 1);
                                op1 = Convert.ToInt32(Console.ReadLine());
                                lista[i] = op1;
                            }
                            Console.Write("\nSoma total = " + operacao.eval(lista));
                        
                      
                        break;
                    case 2:
                            operacao = new Subtracao();

                            Console.Clear();
                            Console.Write("Digite quantidade de valores que deseja subtrair: ");
                            int op2 = Convert.ToInt32(Console.ReadLine());
                          
                            Double[] lista2 = new Double[op2];
                            for (int i = 0; i < lista2.Length; i++)
                            {
                                Console.Write("Valor {0}: ", i + 1);
                                op2 = Convert.ToInt32(Console.ReadLine());
                                lista2[i] = op2;
                            }
                            Console.Write("\nSubtração total = " + operacao.eval(lista2));
                      
                        break;
                    case 3:
                            operacao = new Divisao();

                            Console.Clear();
                            Console.Write("Digite quantidade de valores que deseja dividir: ");
                            int op3 = Convert.ToInt32(Console.ReadLine());
                       
                            Double[] lista3 = new Double[op3];
                            for (int i = 0; i < lista3.Length; i++)
                            {
                                Console.Write("Valor {0}: ", i + 1);
                                op3 = Convert.ToInt32(Console.ReadLine());
                                lista3[i] = op3;
                            }
                            Console.Write("\nDivisão total = " + operacao.eval(lista3));
                        
                        break;
                    case 4:
                            operacao = new Multiplicacao();

                            Console.Clear();
                            Console.Write("Digite quantidade de valores que deseja Multiplicar: ");
                            int op4 = Convert.ToInt32(Console.ReadLine());
                
                            Double[] lista4 = new Double[op4];
                            for (int i = 0; i < lista4.Length; i++)
                            {
                                Console.Write("Valor {0}: ", i + 1);
                                op4 = Convert.ToInt32(Console.ReadLine());
                                lista4[i] = op4;
                            }
                            Console.Write("\nMultiplicação total = " + operacao.eval(lista4));
                      
                        break;
                    case 5:
                            operacao = new SomaFatorial();
                            
                            Console.Clear();
                            Console.Write("Digite quantidade de valores que deseja o Fatorial: ");
                            int fat = Convert.ToInt32(Console.ReadLine());
                      
                            Double[] lista5 = new Double[fat];
                            for (int i = 0; i < lista5.Length; i++)
                            {
                                Console.Write("Valor {0}: ", i + 1);
                                fat = Convert.ToInt32(Console.ReadLine());
                                lista5[i] = fat;
                            }
                            Console.Write("\nSoma Fatorial total = " + operacao.eval(lista5));
                        
                        break;
                    default:
                        Console.Write("Opção invalida!");
                        break;
                }
            }
    }
}