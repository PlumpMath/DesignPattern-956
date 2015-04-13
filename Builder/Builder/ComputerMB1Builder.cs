using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMB1Builder : ComputerBuilder
    {
        private ComputerMB1 _computer = new ComputerMB1();

        public override void BuildMainboard()
        {
            // Code specific for ComputerMB1 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for ComputerMB1 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for ComputerMB1 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for ComputerMB1 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for ComputerMB1 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for ComputerMB1 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for ComputerMB1 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for ComputerMB1 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for ComputerMB1 Mouse
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
