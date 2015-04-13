using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMA1 : Computer
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
                // Code to calculate the total price
                return 5000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Code to calculate the feedback rate
                return 0.95m;
            }
        }

        public override Dictionary<string, string> Configs
        {
            get
            {
                // Configuration information can be collected based on its building parts

                // Below code is to construct configuration information for demo purpose
                var configs = new Dictionary<string, string>();
                configs.Add("CPU", "Intel Core i3 2120");
                configs.Add("Memory", "Kingston 4GB 1333MHz");
                configs.Add("Graphic Card", "<Integrated with mainboard>");
                // More...
                return configs;
            }
        }
    }
}
