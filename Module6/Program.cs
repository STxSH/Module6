namespace Module6
{
    internal class Program
    {

        //task 6.2.2
        static void Main(string[] args)
        {
            Pen pen = new Pen("Синий", 25);

            Console.WriteLine($"цвет: {pen.color}, цена: {pen.cost}");
            Console.ReadKey();
        }

        class Pen
        {
            public string color;
            public int cost;

            public Pen()
            {
                color = "Черный";
                cost = 10;
            }

            public Pen(string penColor, int penCost)
            {
                color = penColor;
                cost = penCost;
            }
        }
    }
}