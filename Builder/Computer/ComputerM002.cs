using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM002 : Computer
    {
        public override PerformanceLevel PerformanceLevel
        {
            get
            {
                return PerformanceLevel.Game;
            }
        }

        public override decimal Price
        {
            get
            {
                // Some code to calculate the total price
                return 5000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Some code to calculate the feedback rate
                return 0.93m;
            }
        }
    }
}
