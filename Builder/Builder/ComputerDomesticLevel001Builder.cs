using System;

namespace TerrLuo.DesignPattern.Builder
{
    public class ComputerDomesticLevel001Builder : ComputerBuilder
    {
        private ComputerDomesticLevel001 _computer = new ComputerDomesticLevel001();

        public override void BuildCPU()
        {
            // Code specific for ComputerDomesticLevel001 CPU
            _computer.CPU = new CPU_AMD_FX_8350();
        }

        public override void BuildMainboard()
        {
            // Code specific for ComputerDomesticLevel001 Mainboard
        }

        public override void BuildGraphicCard()
        {
            // Code specific for ComputerDomesticLevel001 GraphicCard
        }

        public override void BuildMemory()
        {
            // Code specific for ComputerDomesticLevel001 Memory
        }

        public override void BuildHardDisk()
        {
            // Code specific for ComputerDomesticLevel001 HardDisk
        }

        public override void BuildPower()
        {
            // Code specific for ComputerDomesticLevel001 Power
        }

        public override void BuildMonitor()
        {
            // Code specific for ComputerDomesticLevel001 Monitor
        }

        public override void BuildKeyboard()
        {
            // Code specific for ComputerDomesticLevel001 Keyboard
        }

        public override void BuildMouse()
        {
            // Code specific for ComputerDomesticLevel001 Mouse
        }

        /// <summary>
        /// Get constructed computer
        /// </summary>
        /// <returns></returns>
        public ComputerDomesticLevel001 GetComputerDomesticLevel001()
        {
            return this._computer;
        }
    }
}
