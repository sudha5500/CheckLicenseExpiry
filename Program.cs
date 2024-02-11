using CalculateExpiry;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Check your software expiry Date here.");
        Console.WriteLine("Please enter the software purchase date (in MM-dd-yyyy):");
        CheckExpiry checkExpiry = new CheckExpiry();
        // Read input for purchase date
        if (DateTime.TryParse(Console.ReadLine(), out DateTime purchaseDate))
        {
            DateTime expiryDate = checkExpiry.CalculateExpiryDate(purchaseDate);
            // Display license expiry date
            Console.WriteLine($"The license will expire on: {expiryDate.ToString("MM-dd-yyyy")}");
        }
        else
        {
            Console.WriteLine("Invalid Purchase Date. Please enter a valid date");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}