using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerDirector
    {
        private readonly ComputerBuilder _computerBuilder;

        public ComputerDirector(ComputerBuilder computerBuilder)
        {
            this._computerBuilder = computerBuilder;
        }

        public void Construct()
        {
            this._computerBuilder.BuildMainboard();
            this._computerBuilder.BuildCPU();
            this._computerBuilder.BuildGraphicCard();
            this._computerBuilder.BuildMemory();
            this._computerBuilder.BuildHardDisk();
            this._computerBuilder.BuildPower();
            this._computerBuilder.BuildMonitor();
            this._computerBuilder.BuildKeyboard();
            this._computerBuilder.BuildMouse();
        }
    }
}
