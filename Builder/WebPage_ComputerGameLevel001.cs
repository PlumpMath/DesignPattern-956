using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class WebPage_ComputerGameLevel001
    {
        public void ShowComputerDetail()
        {
            // Get the Builder
            ComputerGameLevel001Builder computerGameLevel001Builder = new ComputerGameLevel001Builder();

            // Get the Director, and it will control building process detail
            var computerDirector = new ComputerDirector(computerGameLevel001Builder);
            computerDirector.Construct();

            // Finally, get the product, after building is finished
            ComputerGameLevel001 computer = computerGameLevel001Builder.GetComputerGameLevel001();

            // Code to show properties of ComputerGameLevel001
        }
    }
}
