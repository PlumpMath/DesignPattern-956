using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerMD1Builder : ComputerBuilder
    {
        private ComputerMD1 _computer = new ComputerMD1();

        public override void BuildMainboard()
        {
            // Code specific for ComputerMD1 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for ComputerMD1 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for ComputerMD1 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for ComputerMD1 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for ComputerMD1 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for ComputerMD1 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for ComputerMD1 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for ComputerMD1 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for ComputerMD1 Mouse
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
