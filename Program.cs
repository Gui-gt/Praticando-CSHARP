using System;

namespace Program
{
    public class Program
    {
        static void Main (){

                string[] alunos  = {"Giovana", "Guilherme", "Daniel", "Luana", "Samuel", "Viviane", "Jenifer", "Ian","Luis", "Diogo"};

                foreach (string aluno in alunos)
                {
                    Console.WriteLine("Seja bem vindo(a): " + aluno);
                }



        }
    }
}using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            for(int velocidade = 0;velocidade < 200;velocidade++){
                Console.WriteLine("A máquina está á "+ velocidade+" por hora");
            }
            Console.WriteLine("o carro atingiu o limite máximo de velocidade que é 150 por hora");
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int horas = 7;

            while(horas >= 7 && horas <= 17){
                
                Console.WriteLine("Horas : "+ horas + " mercado aberto!");
                horas++;
            }
            Console.WriteLine("Mercado fechou pós 17");
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            string[] Pizzaria = {"Calabreza","Portuguesa","Salmão","Italiana","Frango Catupiry"};

            foreach (var pizza in Pizzaria)
            {
                Console.WriteLine("Temos o sabor: "+ pizza+" bom apetite!");
            }
        }
    }
}
using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {

            Console.WriteLine("Contagem regressiva para o lançamento do foguete!");
            for(int c = 1000;c > 0;c--){
                
                Console.WriteLine("Contando "+c);
                
            }

            Console.WriteLine("Foguete em lançamento");
        }
    }
}