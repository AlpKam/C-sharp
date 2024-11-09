namespace daire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin yarıçapı giriniz");
            string input = Console.ReadLine();
            
            int a;
            if (int.TryParse(input, out a))
            {
                double cevre = 2 * Math.PI * a;
                double alan = Math.PI * a * a;

                Console.WriteLine($"Cevre {cevre:F2} Alan {alan:F2} dır");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}