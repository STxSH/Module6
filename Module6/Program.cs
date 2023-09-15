namespace Module6
{
    internal class Program
    {

        //task 6.2.8
        static void Main(string[] args)
        {
            Console.ReadKey();
        }        
    }

    class Rectangle
    {
        public int a;
        public int b;

        public int Square(int a, int b)
        {
            return a * b;
        }

        public Rectangle (int x, int y)
        {
            a = x;
            b = y;
        }

        public Rectangle (int x)
        {
            a = x;
            b = x;
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }
    }
}