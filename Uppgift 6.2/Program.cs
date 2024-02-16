namespace Uppgift_6._1
{
    class Program
    {
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två tal separerad med ett kommatecken");
            int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            int störst = Störst(numbers[0], numbers[1]);
            Console.WriteLine($"{störst} är störst");

        }
    }
}