using Trabalho_LPIII.models;
using Trabalho_LPIII.models.menu;

namespace Polimorfismo {
    public class Program {
        public static void Main(String[] args) {
            int flag = 1;

            while(flag != 0)
            {
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
                MenuOp.Menu(flag);
                
            }
        }
    }
}