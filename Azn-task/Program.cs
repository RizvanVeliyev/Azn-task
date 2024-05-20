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
            int click_button=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter one of them");
            if(click_button==1 )
            {
                for(int i=0;i<3;i++) 
                {
                    Console.WriteLine($"1 AZN = {Rates[i]} {Codes[i]}");
                }
            }

            if(click_button==2 )
            {
                string spesific_rate;
                Console.WriteLine("Please enter the spesific code for information about rate:");
                spesific_rate= Console.ReadLine();
                if(spesific_rate=="USD" || spesific_rate == "usd")
                {
                    Console.WriteLine($"{Rates[0]} - {Codes[0]}");
                }
                else if (spesific_rate == "RUB" || spesific_rate == "rub")
                {
                    Console.WriteLine($"{Rates[1]} - {Codes[1]}");
                }
                else if (spesific_rate == "TRY" || spesific_rate == "try")
                {
                    Console.WriteLine($"{Rates[2]} - {Codes[2]}");
                }
                else
                {
                    Console.WriteLine("this code is not exist!");
                }

            }
            

        }
    }
}