using System;

namespace TerrLuo.DesignPattern.SimpleFactory
{
    class WebPage
    {
        /// <summary>
        /// Show the detailed information of user selected IPhone
        /// </summary>
        public void ShowSelectedPhone()
        {
            string model = GetSelectedPhoneModel();
            IPhone iPhone = IPhoneFactory.Create(model);

            // Code to bind IPhone detail to the web page UI control
        }

        private string GetSelectedPhoneModel()
        {
            // Code to get user selected IPhone model

            return "IPhone6";
        }
    }
}
