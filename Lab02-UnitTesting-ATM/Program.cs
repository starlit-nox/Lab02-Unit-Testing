namespace ATM
{
    public class ATM // This is the overall class for the ATM program.
    {
        public static decimal Balance { get; private set; } = 0; // Setting up the Balanace method in a decimal form.

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal amount) // Setting up the Withdraw method in a decimal form.
        {
            if (amount < 0) // Logic determing if the amount is greater than 0, if not then WriteLine below will be triggered.
            {
                Console.WriteLine("Invalid amount. Please enter a positive value."); // Prints the text invalid amount.
                return 0;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds."); // Prints the text insufficient funds.
                return 0;
            }

            Balance -= amount;
            return amount;
        }

        public static decimal Deposit(decimal amount) // Setting up the Depoist method in a decimal form.
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive value."); // Prints the text invalid amount
                return 0;
            }

            Balance += amount;
            return amount;
        }

        public static void UserInterface() // This is the UserInterface function, its out putting strings for the text.
        {
            string choice;
            do
            {
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice) // This is setting the case choices for the user to switch between.
                {
                    case "1":
                        Console.WriteLine($"Current Balance: {ViewBalance():C}");
                        break;
                    case "2":
                        Console.Write("Enter amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            decimal withdrawn = Withdraw(withdrawAmount);
                            Console.WriteLine($"Withdrawn: {withdrawn:C}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            decimal deposited = Deposit(depositAmount);
                            Console.WriteLine($"Deposited: {deposited:C}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != "4");
        }

        public static void Main()
        {
            UserInterface();
        }
    }
}
