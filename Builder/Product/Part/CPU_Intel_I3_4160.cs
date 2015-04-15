using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class CPU_Intel_I3_2120
    {
        public string Summary
        {
            get
            {
                return "Intel I3 2120";
            }
        }

        public string ClockSpeed
        {
            get
            {
                return "3.6 GHz";
            }
        }

        /// <summary>
        /// 集成显示核心
        /// </summary>
        public string IntegratedGrahicCore
        {
            get
            {
                return "Intel HD Grahpic 440";
            }
        }
    }
}
