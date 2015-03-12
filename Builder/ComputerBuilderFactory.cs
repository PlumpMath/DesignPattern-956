using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerBuilderFactory
    {
        public ComputerBuilder Create(string selectedComputerModel)
        {
            ComputerBuilder computerBuilder;

            switch (selectedComputerModel)
            {
                case "M001":
                    computerBuilder = new ComputerM001Builder();
                    break;

                case "M002":
                    computerBuilder = new ComputerM002Builder();
                    break;

                case "M003":
                    computerBuilder = new ComputerM003Builder();
                    break;

                case "M004":
                    computerBuilder = new ComputerM004Builder();
                    break;

                default:
                    computerBuilder = new ComputerM001Builder();
                    break;
            }

            return computerBuilder;
        }
    }
}
