using System;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerDomesticLevel001
    {

        public decimal Price
        {
            get
            {
                // Code to calculate the total price based on all its parts
                return 5000;
            }
        }

        public decimal FeedbackRate
        {
            get
            {
                // Code to calculate the feedback rate
                return 0.95m;
            }
        }

        #region Computer Part

        public CPU_AMD_FX_8350 CPU { get; set; }

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

        #region More Specific Member

        /// <summary>
        /// 促销价
        /// </summary>
        public decimal PromotionPrice { get; set; }

        public void OperationA()
        {
            // Code
        }

        public void OperationB()
        {
            // Code
        }

        #endregion
    }
}
