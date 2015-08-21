namespace Problem02.RefactorIfStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Chef;

    public class Potato
    {
        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsCooked { get; set; }

        public void Cook()
        {
            this.IsCooked = true;
        }
    }
}
