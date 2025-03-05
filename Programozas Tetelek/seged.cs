namespace Programozas_Tetelek
{
    class seged
    {
        public int[] arrayCreation()
        {
            Console.WriteLine("Kérlek add meg a tömb hosszát!");
            int hossz = int.Parse(Console.ReadLine());
            int[] tomb = new int[hossz];

            Console.WriteLine("Kérlek add meg a számokat!");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = int.Parse(Console.ReadLine());
            }
            return tomb;
        }
    }
}
