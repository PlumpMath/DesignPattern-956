using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerM001Builder : ComputerBuilder
    {
        private ComputerM001 _computer = new ComputerM001();

        public override void BuildMainboard()
        {
            // Code specific for Computer001 Mainboard
        }

        public override void BuildCPU()
        {
            // Code specific for Computer001 CPU
        }

        public override void BuildGraphicCard()
        {
            // Code specific for Computer001 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for Computer001 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for Computer001 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for Computer001 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for Computer001 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for Computer001 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for Computer001 Mouse
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
