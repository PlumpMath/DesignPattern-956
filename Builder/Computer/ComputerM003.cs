using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM003 : Computer
    {
        public override PerformanceLevel PerformanceLevel
        {
            get
            {
                return PerformanceLevel.Luxurious;
            }
        }

        public override decimal Price
        {
            get
            {
                // Some code to calculate the total price
                return 8000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Some code to calculate the feedback rate
                return 0.99m;
            }
        }
    }
}
