namespace Module6
{
    internal class Program
    {

        //task 6.3.2
        static void Main(string[] args)
        {
            Console.ReadKey();
        }        
    }
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine($"Количесвто пассажиров: {Load.Value}");
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
        }
    }
}