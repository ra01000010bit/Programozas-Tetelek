using Programozas_Tetelek.EgyszeruProgramozasTetelek;

namespace Programozas_Tetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Welcome massage + start menu

            Console.WriteLine("Hello");

            Console.WriteLine("Kérlek válassza az alábbi menü pontok közül!");
            Console.WriteLine("1. Egyszerű programozási tételek.");
            Console.WriteLine("2. Összetett programozási tételek.");
            Console.WriteLine("3. Programozási tételek össze építése");

            int mainAnswer = int.Parse(Console.ReadLine());
            Console.Clear();
            #endregion

            switch (mainAnswer)
            {
                default:
                    Console.WriteLine("Nincs ilyen opció.");
                    break;
                case 1:
                    Console.WriteLine("Egyszerű programozási tételek.");
                    Console.WriteLine("Kérlek válassza az alábbi menü pontok közül!");
                    Console.WriteLine("1. Sorozatszámítás programozási tétel");
                    Console.WriteLine("2. Eldöntés programozási tétel");

                    int subAnswer = int.Parse(Console.ReadLine());
                    switch (subAnswer)
                    {
                        default:
                            Console.WriteLine("Nincs ilyen opció.");
                            break;
                        case 1:
                            Console.WriteLine("Sorozatszámítás programozási tétel");
                            Console.WriteLine("Kérlek add meg hogy összadás(1) vagy szorzás(2)");
                            int sign = int.Parse(Console.ReadLine());
                            SorozatszamitasProgramozasTetel szamitas = new SorozatszamitasProgramozasTetel();
                            seged tombLetrehozas = new seged();
                            int[] tomb = tombLetrehozas.arrayCreation();
                            switch (sign)
                            {
                                default:
                                    Console.WriteLine("Nincs ilyen opció.");
                                    break;
                                case 1:
                                    Console.WriteLine($"{szamitas.SorozatszamitasOsszeadas(tomb)}");
                                    break;
                                case 2:
                                    Console.WriteLine($"{szamitas.SorozatszamitasSzorzas(tomb)}");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
            }

        }
    }
}
