using System;

namespace CalculatorExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Receipt Builder Demo ===\n");

            // Create a receipt for "Corner Market"
            var receipt = new ReceiptBuilder("Feelings Supermarket");

            // Add some items
            receipt.AddItem("Bread", 2, 2.50m);
            receipt.AddItem("Milk", 1, 3.49m);
            receipt.AddItem("Eggs", 12, 0.25m);
            receipt.AddItem("Apples", 5, 0.75m);

            // Build and display the receipt
            Console.WriteLine(receipt.Build());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}