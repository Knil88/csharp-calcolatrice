namespace sharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcoliHelper.Somma(1, 2));
            Console.WriteLine(CalcoliHelper.Somma(1.0, 2.0));
            Console.WriteLine(CalcoliHelper.Differenza(1, 2));
            Console.WriteLine(CalcoliHelper.Differenza(1.0, 2.0));
            Console.WriteLine(CalcoliHelper.Moltiplicazione(1, 2));
            Console.WriteLine(CalcoliHelper.Moltiplicazione(1.0, 2.0));
            Console.WriteLine(CalcoliHelper.ValoreAssoluto(-1));
            Console.WriteLine(CalcoliHelper.ValoreAssoluto(-1.0));
            Console.WriteLine(CalcoliHelper.Minimo(1, 2));
            Console.WriteLine(CalcoliHelper.Minimo(1.0, 2.0));
            Console.WriteLine(CalcoliHelper.Massimo(1, 2));
            Console.WriteLine(CalcoliHelper.Massimo(1.0, 2.0));
        }
      

    }

}