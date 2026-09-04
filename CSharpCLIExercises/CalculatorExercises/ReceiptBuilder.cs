using System;
using System.Text;

namespace CalculatorExercises
{
    public class ReceiptBuilder //Step 1; Class
    {
        private readonly StringBuilder _sb; //Step 2; Variable
        private decimal _total;

        public ReceiptBuilder(string storeName) //Step 3; Constructor
        {
            _sb = new StringBuilder();
            _sb.AppendLine($"===== {storeName} ====="); //$= string interpolation
        }

        public void AddItem(string name, int quantity, decimal price) //Step 4; Method
        {
            decimal lineTotal = quantity * price;
            _total += lineTotal;
            _sb.AppendLine($"{name,-15}{quantity,4}{lineTotal,10:C}");
        }

        public string Build() //Step 5; Build Method
        {
            _sb.AppendLine(new string('-', 29));
            _sb.AppendLine($"{"TOTAL",-19}{_total,10:C}");
            return _sb.ToString();
        }
    }
}