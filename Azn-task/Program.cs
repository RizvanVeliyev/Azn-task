namespace Azn_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if you want to show recent currency rates click 1:");
            Console.WriteLine("if you want to find currency rate by spesific code click 2:");
            Console.WriteLine("if you want to calculate amount by currency click 3 and enter the amount with AZN:");
            Console.WriteLine("if you want to exit program click -1:");
            string[] Codes = { "USD", "RUB", "TRY" };
            double[] Rates = { 0.59, 53.46, 18.94 };
            int click_button;

            while (true)
            {
                
                
                Console.WriteLine("Enter one of them(1,2,3,-1):");
                click_button = int.Parse(Console.ReadLine());
                if (click_button == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"1 AZN = {Rates[i]} {Codes[i]}");
                    }
                }

                if (click_button == 2)
                {
                    string spesific_rate;
                    Console.WriteLine("Please enter the spesific code for information about rate:");
                    spesific_rate = Console.ReadLine();
                    if (spesific_rate == "USD" || spesific_rate == "usd")
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

                if (click_button == 3)
                {
                    int price_azn;
                    string rate_code;
                    Console.WriteLine("enter the price with AZN:");
                    price_azn = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the code which you want to calculate:");
                    rate_code = Console.ReadLine();
                    double result = -1;
                    if (rate_code == "USD" || rate_code == "usd")
                    {
                        result = price_azn * Rates[0];
                    }
                    else if (rate_code == "RUB" || rate_code == "rub")
                    {
                        result = price_azn * Rates[1];
                    }
                    else if (rate_code == "TRY" || rate_code == "try")
                    {
                        result = price_azn * Rates[2];
                    }
                    else
                    {
                        Console.WriteLine("this code is not exist!");
                    }
                    if (result != -1)
                        Console.WriteLine($"result={result:F2} {rate_code}");

                }

                if (click_button == -1) 
                {
                    Console.WriteLine("Your program has finished!");
                    break;
                }
                else
                {
                    Console.WriteLine("if you want to show recent currency rates click 1:");
                    Console.WriteLine("if you want to find currency rate by spesific code click 2:");
                    Console.WriteLine("if you want to calculate amount by currency click 3 and enter the amount with AZN:");
                    Console.WriteLine("if you want to exit program click -1:");

                }

            }
            
            

        }
    }
}