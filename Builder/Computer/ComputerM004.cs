using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM004 : Computer
    {
        public override PerformanceLevel PerformanceLevel
        {
            get
            {
                return PerformanceLevel.Enthusiastic;
            }
        }

        public override decimal Price
        {
            get
            {
                // Some code to calculate the total price
                return 15000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Some code to calculate the feedback rate
                return 0.90m;
            }
        }
    }
}
