using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMC1 : Computer
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
                // Code to calculate the total price
                return 20000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Code to calculate the feedback rate
                return 0.99m;
            }
        }

        public override Dictionary<string, string> Configs
        {
            get
            {
                // Configuration information can be collected based on its building parts

                // Below code is to construct configuration information for demo purpose
                var configs = new Dictionary<string, string>();
                configs.Add("CPU", "Intel Core i7 4790k");
                configs.Add("Memory", "G.SKILL 16G 2400MHZ (Dual Channel: 8GB X 2)");
                configs.Add("Graphic Card", "ZOTAC GTX970-4GD5");
                // More...
                return configs;
            }
        }
    }
}
