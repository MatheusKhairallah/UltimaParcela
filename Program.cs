using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digíte o valor total a ser pago, a quantidade de parcelas mensais e a data de hoje.");
            Console.WriteLine("Então te darei a data e o valor da última parcela de sua compra.");
            
            Console.Write("Valor total a ser pago: ");
            int valor=Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantidade de parcelas: ");
            int parcelas=Convert.ToInt32(Console.ReadLine());
            Console.Write("Data de hoje: ");
            DateTime data=Convert.ToDateTime(Console.ReadLine());

            DateTime mês=DateTime.Today.AddMonths(parcelas);
            double UltimaParcela=valor / parcelas;

            Console.Clear();
            Console.WriteLine($"Sua última parcela será em {mês}, no valor de {UltimaParcela:C}");
        }
    }
}
