
namespace PRATICANDO_C_
{
    public class Program
    {
        static void Main ()
        {
            int recebe_area = Praça(250,350);
            Console.WriteLine("o tamanho da praça é: " + recebe_area + " m2");
        }

        static int Praça(int Base, int Altura)
        {
            int area = (Base * Altura) \2;
            return area;

        }
    }
}
