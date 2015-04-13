using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMB1 : Computer
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
                // Code to calculate the total price
                return 9000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Code to calculate the feedback rate
                return 0.93m;
            }
        }

        public override Dictionary<string, string> Configs
        {
            get
            {
                // Configuration information can be collected based on its building parts

                // Below code is to construct configuration information for demo purpose
                var configs = new Dictionary<string, string>();
                configs.Add("CPU", "Intel Core i5 3470");
                configs.Add("Memory", "Kingston 8GB 1600MHz (Dual Channel: 4GB X 2)");
                configs.Add("Graphic Card", "Galaxy GTX750 Ti Gamer");
                // More...
                return configs;
            }
        }
    }
}
