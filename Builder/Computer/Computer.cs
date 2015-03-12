using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Builder
{
    public abstract class Computer
    {
        public abstract PerformanceLevel PerformanceLevel
        {
            get;
        }

        public abstract decimal Price
        {
            get;
        }

        public abstract decimal FeedbackRate
        {
            get;
        }
    }
}
