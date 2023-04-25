namespace AprendendoCsharp___6_AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

            int idade = 30;
            int idadeAna = idade;
            Console.WriteLine(idadeAna);
            idade = 25;
            string parcela_1 = "10";
            string parcela_2 = "20";

            Console.WriteLine(parcela_1 + parcela_2);
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}