namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto e tecle enter");
            string texto = (Console.ReadLine());
            int quantidadeCaracteres = texto.Length;
            for (int i = quantidadeCaracteres; i != 0; i--)
            {
                Console.Write(texto.ElementAt(i - 1));
            }
        }
    }
}