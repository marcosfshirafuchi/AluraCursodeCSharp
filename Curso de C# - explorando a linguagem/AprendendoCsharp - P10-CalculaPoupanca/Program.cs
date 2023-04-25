namespace AprendendoCsharp___P10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança");
            double investimento = 1000;

            // redimento de 0.5%(0.005) ao mês
            //Mês 01
            //investimento = investimento + investimento * 0.005;
            //Mês 02
            //investimento = investimento + investimento * 0.005;
            //Mês 03
            //investimento = investimento + investimento * 0.005;
            //Console.WriteLine(investimento);
             int mes = 1;
             while (mes <= 12) 
             {
                 investimento = investimento + investimento * 0.005;
                 Console.WriteLine("No mês "+ mes + " você tem R$ " +investimento);
                 //mes = mes +1; ou mes++;
                 mes += 1;


             }
            
            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}