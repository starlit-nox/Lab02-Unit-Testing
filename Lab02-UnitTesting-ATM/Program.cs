namespace Lab02ATM
{
    public class Program // This is the overall class for the ATM program.
    {
        public static decimal Balance { get; set; } = 0; // Setting up the Balance property in a decimal form.

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal amount) // Setting up the Withdraw method in a decimal form.
        {
            if (amount < 0) // Logic determining if the amount is less than 0, if so, the WriteLine below will be triggered.
            {
                Console.WriteLine("Invalid amount."); // Prints the text "Invalid amount."
                return 0;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds."); // Prints the text "Insufficient funds."
                return 0;
            }

            Balance -= amount;
            return Balance; // Return the updated balance after withdrawal
        }

        public static decimal Deposit(decimal amount) // Setting up the Deposit method in a decimal form.
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid amount."); // Prints the text "Invalid amount."
                return 0;
            }

            Balance += amount;
            return Balance; // Return the updated balance after deposit
        }

        public static void UserInterface() // This is the UserInterface function, it outputs strings for the text.
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

                switch (choice) // This sets the case choices for the user to switch between.
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
