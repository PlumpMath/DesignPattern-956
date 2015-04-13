using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMC1Builder : ComputerBuilder
    {
        private ComputerMC1 _computer = new ComputerMC1();

        public override void BuildMainboard()
        {
            // Code specific for ComputerMC1 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for ComputerMC1 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for ComputerMC1 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for ComputerMC1 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for ComputerMC1 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for ComputerMC1 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for ComputerMC1 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for ComputerMC1 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for ComputerMC1 Mouse
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
