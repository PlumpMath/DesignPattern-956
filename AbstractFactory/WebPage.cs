using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class WebPage
    {
        public void ShowProduct()
        {
        }

        private AbstractFactory GetFactory(string selectedManufacturer)
        {
            switch(selectedManufacturer)
            {
                case "Apple":
                    return new AppleFamilyFactoryV2();

                case "Microsoft":
                    return new MicrosoftFamilyFactoryV2();

                default:
                    throw new InvalidOperationException(); 
            }
        }

        private string GetSelectedManufacturer()
        {
            // Code to get selected manufacturer
            return "Apple";
        }
    }
}
