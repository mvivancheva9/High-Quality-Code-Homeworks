namespace PrintingVariable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Printing
    {
        private const int MaxCounter = 6;

        public class BooleanPrinter
        {
            public void Print(bool value)
            {
                string valueAsSting = value.ToString();
                Console.WriteLine(valueAsSting);
            }
        }       
    }
}
