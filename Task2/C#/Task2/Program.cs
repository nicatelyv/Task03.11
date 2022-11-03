namespace Task2
{
    internal class Program
    {
        private static readonly int length;

        static void Main(string[] args)
        {
            int [] num = { 1,1,2,3,4,4,5,5,5,5,6,7,8,9,9,10};
            int Tekrarlar = 0;
            
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1 ; j < num.Length; j++)
                {
                    if (num[i]==num[j])
                    {
                        Tekrarlar= num[i]
                        Console.WriteLine(num[i] + "-" + num[j]);
                    }
                }

            }
        }
    }
}