using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class WebPage
    {
        public void DropDownList_SelectedItemChanged()
        {
            string selectedComputerName = GetSelectedComputerName();
            ShowSelectedComputer(selectedComputerName);
        }

        private void ShowSelectedComputer(string selectedComputerName)
        {
            // Get the proper Builder
            var computerBuilder = ComputerBuilderFactory.Create(selectedComputerName);

            // Get the Director, and it will control building process detail
            var computerDirector = new ComputerDirector(computerBuilder);
            computerDirector.Construct();

            // Finally, get the product, after building is finished
            var computer = computerBuilder.GetComputer();

            // Code to show properties of selected computer
        }

        /// <summary>
        /// Get selected computer name
        /// </summary>
        /// <returns></returns>
        private string GetSelectedComputerName()
        {
            // Code to get selected computer name
            return "ComputerMD1";
        }
    }
}
