using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class WebPage_ComputerDomesticLevel001
    {
        public void ShowComputerDetail()
        {
            // Get the Builder
            ComputerDomesticLevel001Builder computerDomesticLevel001Builder = new ComputerDomesticLevel001Builder();

            // Get the Director, and it will control building process detail
            var computerDirector = new ComputerDirector(computerDomesticLevel001Builder);
            computerDirector.Construct();

            // Finally, get the product, after building is finished
            ComputerDomesticLevel001 computer = computerDomesticLevel001Builder.GetComputerDomesticLevel001();

            // Code to show properties of ComputerDomesticLevel001
        }
    }
}
