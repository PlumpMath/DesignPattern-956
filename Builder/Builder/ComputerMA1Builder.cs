using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMA1Builder : ComputerBuilder
    {
        private ComputerMA1 _computer = new ComputerMA1();

        public override void BuildMainboard()
        {
            // Code specific for ComputerMA1 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for ComputerMA1 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for ComputerMA1 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for ComputerMA1 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for ComputerMA1 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for ComputerMA1 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for ComputerMA1 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for ComputerMA1 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for ComputerMA1 Mouse
        }

        /// <summary>
        /// Get built computer
        /// </summary>
        /// <returns></returns>
        public override Computer GetComputer()
        {
            return this._computer;
        }
    }
}
