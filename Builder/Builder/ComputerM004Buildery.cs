using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM004Builder : ComputerBuilder
    {
        private ComputerM004 _computer = new ComputerM004();

        public override void BuildMainboard()
        {
            // Code specific for Computer004 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for Computer004 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for Computer004 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for Computer004 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for Computer004 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for Computer004 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for Computer004 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for Computer004 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for Computer004 Mouse
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
