using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMD1 : Computer
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
                // Code to calculate the total price
                return 50000;
            }
        }

        public override decimal FeedbackRate
        {
            get
            {
                // Code to calculate the feedback rate
                return 0.90m;
            }
        }

        public override Dictionary<string, string> Configs
        {
            get
            {
                // Configuration information can be collected based on its building parts

                // Below code is to construct configuration information for demo purpose
                var configs = new Dictionary<string, string>();
                configs.Add("CPU", "Intel core i7 5960x");
                configs.Add("Memory", "G.SKILL 64G 2666MHZ (Dual Channel: 8GB X 8)");
                configs.Add("Graphic Card", "LEADTEK NVIDIA Quadro K5200");
                // More...
                return configs;
            }
        }
    }
}
