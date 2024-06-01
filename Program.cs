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