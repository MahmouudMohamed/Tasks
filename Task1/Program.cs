namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Islam's Carpet Cleaning Service");
            Console.WriteLine("Price per small carpets: $25" +
                "\nPrice per large carpets: $35" +
                "\nSales tax rate is 6%");
            Console.Write("Enter Number Of Small carpets : ");
            int priceOfSmall = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number Of Large carpets : ");
            int priceOfLarge = Convert.ToInt32(Console.ReadLine());
            int cost = (priceOfSmall * 25) + (priceOfLarge * 35);
            Console.WriteLine($"Cost = ${cost}");
            double tax = cost * 0.06;
            Console.WriteLine($"Tax = ${tax}");
            Console.WriteLine("==============================");
            Console.WriteLine($"Total estimate: {cost + tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
