using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerGameLevel001Builder : ComputerBuilder
    {
        private ComputerGameLevel001 _computer = new ComputerGameLevel001();

        public override void BuildCPU()
        {
            _computer.CPU = new CPU_Intel_I3_2120();
        }

        public override void BuildMainboard()
        {
            // Code specific for ComputerGameLevel001 Mainboard
        }

        public override void BuildGraphicCard()
        {
            // Code specific for ComputerGameLevel001 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for ComputerGameLevel001 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for ComputerGameLevel001 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for ComputerGameLevel001 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for ComputerGameLevel001 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for ComputerGameLevel001 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for ComputerGameLevel001 Mouse
        }

        /// <summary>
        /// Get constructed computer
        /// </summary>
        /// <returns></returns>
        public ComputerGameLevel001 GetComputerGameLevel001()
        {
            return this._computer;
        }
    }
}
