using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM002Builder : ComputerBuilder
    {
        private ComputerM002 _computer = new ComputerM002();

        public override void BuildMainboard()
        {
            // Code specific for Computer002 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for Computer002 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for Computer002 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for Computer002 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for Computer002 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for Computer002 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for Computer002 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for Computer002 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for Computer002 Mouse
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
