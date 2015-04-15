using System;

namespace TerrLuo.DesignPattern.Builder
{
    public abstract class ComputerBuilder
    {
        public abstract void BuildMainboard();
        public abstract void BuildCPU();
        public abstract void BuildGraphicCard();
        public abstract void BuildMemory();
        public abstract void BuildHardDisk();
        public abstract void BuildPower();
        public abstract void BuildMonitor();
        public abstract void BuildKeyboard();
        public abstract void BuildMouse();
    }
}
