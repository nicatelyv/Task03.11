namespace Task1
{
    internal class Program
    {
        private static readonly int reqem2;

        public static int reqem1 { get; private set; }

        static void Main(string[] args)
        {
        
            int a, b, c;

            Console.WriteLine("A ededini daxil edin: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B ededini daxil edin: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > 50 && b > 50)
            {
                Console.WriteLine("Cemi:"+ (c = a + b));
            }
            else
            {
                Console.WriteLine("Bu ededler uygun deyil");


            }


        }
    }
}