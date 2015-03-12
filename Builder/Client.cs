using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class Client
    {
        public void GetSelectedComputer(string selectedComputerModel)
        {
            var computerBuilder = new ComputerBuilderFactory().Create(selectedComputerModel);

            var computerDirector = new ComputerDirector(computerBuilder);
            computerDirector.Construct();

            var computer = computerBuilder.GetComputer(); 
        }
    }
}
