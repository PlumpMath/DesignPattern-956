using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM003Builder : ComputerBuilder
    {
        private ComputerM003 _computer = new ComputerM003();

        public override void BuildMainboard()
        {
            // Code specific for Computer003 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for Computer003 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for Computer003 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for Computer003 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for Computer003 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for Computer003 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for Computer003 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for Computer003 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for Computer003 Mouse
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
