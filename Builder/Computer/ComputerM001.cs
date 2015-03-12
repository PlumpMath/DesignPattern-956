using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM001 : Computer
    {
        public override PerformanceLevel PerformanceLevel
        {
            get
            {
                return PerformanceLevel.Family;
            }
        }

        public override decimal Price
        {
            get
            {
                // Some code to calculate the total price
                return 3000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Some code to calculate the feedback rate
                return 0.95m;
            }
        }
    }
}
