using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerBuilderFactory
    {
        public static ComputerBuilder Create(string selectedComputerName)
        {
            ComputerBuilder computerBuilder;

            switch (selectedComputerName)
            {
                case "ComputerMA1":
                    computerBuilder = new ComputerMA1Builder();
                    break;

                case "ComputerMB1":
                    computerBuilder = new ComputerMB1Builder();
                    break;

                case "ComputerMC1":
                    computerBuilder = new ComputerMC1Builder();
                    break;

                case "ComputerMD1":
                    computerBuilder = new ComputerMD1Builder();
                    break;

                default:
                    computerBuilder = new ComputerMA1Builder();
                    break;
            }

            return computerBuilder;
        }
    }
}
