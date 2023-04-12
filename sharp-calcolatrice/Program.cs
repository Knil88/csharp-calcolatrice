namespace sharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Somma: {CalcoliHelper.Somma(1, 2)}");
            Console.WriteLine($"Somma: {CalcoliHelper.Somma(1.0, 2.0)}");
            Console.WriteLine($"Differenza: { CalcoliHelper.Differenza(1, 2)}");
            Console.WriteLine($"Differenza: {CalcoliHelper.Differenza(1.0, 2.0)}");
            Console.WriteLine($"Prodotto : {CalcoliHelper.Moltiplicazione(1, 2)}");
            Console.WriteLine($"Prodotto : {CalcoliHelper.Moltiplicazione(1.0, 2.0)}");
            Console.WriteLine($"Valore Assoluto : {CalcoliHelper.ValoreAssoluto(-1)}");
            Console.WriteLine($"Valore Assoluto : {CalcoliHelper.ValoreAssoluto(-1.0)}");
            Console.WriteLine($"Valore Minimo : {CalcoliHelper.Minimo(1, 2)}");
            Console.WriteLine($"Valore Minimo : {CalcoliHelper.Minimo(1.0, 2.0)}");
            Console.WriteLine($"Valore Massimo :{CalcoliHelper.Massimo(1, 2)}");
            Console.WriteLine($"Valore Massimo : {CalcoliHelper.Massimo(1.0, 2.0)}");
        }
      

    }

}