namespace PrintingVariable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VariablePrinting
    {
        public static void Main()
        {
            var printer = new Printing.BooleanPrinter();
            printer.Print(true);
            printer.Print(false);
        }
    }
}
