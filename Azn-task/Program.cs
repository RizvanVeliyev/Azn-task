namespace Azn_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] Codes = { "USD", "RUB", "TRY" };
            double[] Rates = { 0.59, 53.46, 18.94 };
            Console.WriteLine("if you want to show recent currency rates click 1:");
            Console.WriteLine("if you want to find currency rate by spesific code click 2:");
            Console.WriteLine("if you want to calculate amount by currency click 3 and enter the amount with AZN:");
            int click_buttonint=int.Parse(Console.ReadLine());
            if(click_buttonint==1 )
            {
                for(int i=0;i<3;i++) 
                {
                    Console.WriteLine($"1 AZN={Rates[i]} {Codes[i]}");
                }
            }
            

        }
    }
}