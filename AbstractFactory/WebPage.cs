using System;

namespace TerrLuo.DesignPattern.AbstractFactory
{
    public class WebPage
    {
        public void ShowProduct()
        {
            string selectedManufacturer = GetSelectedManufacturer();
            AbstractFactory factory = GetFactory(selectedManufacturer);
            Pad pad = factory.CreatePad();
            Phone phone = factory.CreatePhone();

            // Code to bind Pad & Phone's properties to UI controls.
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
