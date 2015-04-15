using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class CPU_AMD_FX_8350
    {
        public string Summary
        {
            get
            {
                return "AMD FX 8350";
            }
        }

        public string ClockSpeed
        {
            get
            {
                return "4.0 GHz";
            }
        }

        /// <summary>
        /// 动态加速
        /// </summary>
        public string ClockSpeedDynamicAccelerated
        {
            get
            {
                return "4.2 GHz";
            }
        }
    }
}
