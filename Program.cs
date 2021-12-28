// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace ATMTRANSACTION
{
    class Program
    {
        static void Main(string[] args)
        {
            int amt = 500;
            int dep, wit;
            int ch, pin = 0, x = 0;
            Console.WriteLine("Your pin number ====> ");
            pin= int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine(" A T M  S E R V I C E s\n");
                Console.WriteLine("======================\n");
                Console.WriteLine("1. Check Account Balance\n");
                Console.WriteLine("2. Withdraw\n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Exit\n\n\n");
                Console.WriteLine("Select your Option ===> ");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("\n\n Your Balance is : {0} ", amt);
                        break;
                    case 2:
                        Console.WriteLine("Amount to be Withdrawn");
                        wit = int.Parse(Console.ReadLine());

                        if (wit % 100 != 0)
                        {
                            Console.WriteLine("\n\n Enter the amount  in multiple of 100 ");
                        }
                        else if (wit > (amt - 200))
                        {
                            Console.WriteLine("\n Insufficient Fund");
                        }
                        else
                        {
                            amt = amt - wit;
                            Console.WriteLine("\n Take your Cash");
                            Console.WriteLine("\n Current Balance is {0}", amt);
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n Enter the amount to be deposited");
                        dep = int.Parse(Console.ReadLine());
                        amt = amt + dep;

                        Console.WriteLine("\nCureent Balance is {0} ", amt);

                        break;

                    case 4:
                        Console.WriteLine("\n T H A N K YOU :)");

                        break;



          
                }

            }

        }
    }
}

