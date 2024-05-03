namespace ifelsevärk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 10;
            int y = 20;

            if (x > y)
            {
                Console.WriteLine("x on suurem kui y");
            }
            else
            {
                if (y > x)
                {
                    Console.WriteLine("y on suurem kui x");
                }
                else
                {
                    Console.WriteLine("x on väiksem kui y");
                }
            }
        }
    }
}
