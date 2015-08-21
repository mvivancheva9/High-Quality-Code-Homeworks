namespace Problem02.RefactorIfStatements
{
    using System; 

    public class IfStatements
    {
        public static void Main(string[] args)
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                bool isPeeled = !potato.IsPeeled;
                bool isRotten = !potato.IsRotten;
                if (isPeeled == false && isRotten == false)
                {
                    potato.Cook();
                }
            }

            var MIN_X = 20;
            var MIN_Y = 20;
            var MAX_X = 30;
            var MAX_Y = 30;
            var x = 25;
            var y = 25;
            bool inRangeY = MAX_Y >= y && MIN_Y <= y;
            bool inRangeX = MAX_X >= x && MIN_X <= x;
            bool shouldVisitCell = true;
            if (shouldVisitCell && inRangeX && inRangeY)
            {
                VisitCell();
            }
        }

        public static void VisitCell()
        {
            Console.WriteLine("Visited");
        }
    }
}
