using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerGameLevel001
    {
        public decimal Price
        {
            get
            {
                // Code to calculate the total price based on all its parts
                return 9000;
            }
        }

        public decimal FeedbackRate
        {
            get
            {
                // Code to calculate the feedback rate
                return 0.93m;
            }
        }

        #region Computer Part

        public CPU_Intel_I3_2120 CPU
        {
            get;
            set;
        }

        /*
         * Below properties should not be of string type.
         * E.g. type of Memory          should be something like    Memory_Kingston_1333
         *      type of GraphicCard     should be something like    GraphicCard_Asus_GTX760
         *      ...
         *      ...
         *      ...
        */

        public string Memory { get; set; }
        public string GraphicCard { get; set; }
        public string Mainboard { get; set; }
        public string Disk { get; set; }
        public string Monitor { get; set; }
        public string Mouse { get; set; }
        public string Keyboard { get; set; }

        #endregion


        #region Computer Part

        /// <summary>
        /// 赠品(打印机)
        /// </summary>
        public string PrinterGift { get; set; }

        /// <summary>
        /// 赠品(游戏操纵杆)
        /// </summary>
        public string XBoxGift { get; set; }

        public void OperationD()
        {
            // Code
        }

        public void OperationE()
        {
            // Code
        }

        public void OperationF()
        {
            // Code
        }

        #endregion
    }
}
