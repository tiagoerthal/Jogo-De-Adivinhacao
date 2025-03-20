namespace JogoDeAdivinhacao.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Jogo De Adivinhação");
            Console.WriteLine("--------------------------------------");

            Console.Write("Digite um número para chutar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Você digitou o número: " + numeroDigitado);

            Console.ReadLine(); 


        }

    }
}
