namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en summa pengar i SEK");
            double summa1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vilken valuta vill du omvandla till");
            Console.WriteLine("Du kan kan välja mellan:");
            Console.WriteLine("- EUR");
            Console.WriteLine("- GBP");
            Console.WriteLine("- JPY");
            Console.WriteLine("- USD");
            string valuta1 = (Console.ReadLine());

            switch (valuta1)
            {
                case "EUR":
                    double Euro = 0.10;
                    double resultat1 = summa1 * Euro;
                    Console.WriteLine($"resultat: {resultat1}");
                    break;

                case "GBP":
                    double GPB = 0.08;
                    double resultat2 = summa1 * GPB;
                    Console.WriteLine($"resultat: {resultat2}");
                    break;

                case "JPY":
                    double JPY = 15.73;
                    double resultat3 = summa1 * JPY;
                    Console.WriteLine($"resultat: {resultat3}");
                    break;

                case "USD":
                    double USD = 9.98;
                    double resultat4 = summa1 * USD;
                    Console.WriteLine($"resultat: {resultat4}");
                    break;

                default:
                    Console.WriteLine("Valutan är inte tillgänglig");
                    break;
            }


        }
    }
}
