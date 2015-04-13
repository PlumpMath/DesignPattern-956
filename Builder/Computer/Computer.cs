using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Builder
{
    public abstract class Computer
    {
        /// <summary>
        /// Computer's performance level: such as Family, Game, Luxurious, Enthusiastic
        /// </summary>
        public abstract PerformanceLevel PerformanceLevel
        {
            get;
        }

        /// <summary>
        /// Computer's total price based on its parts
        /// </summary>
        public abstract decimal Price
        {
            get;
        }

        /// <summary>
        /// Computer's average rate based on users' feedback
        /// </summary>
        public abstract decimal FeedbackRate
        {
            get;
        }

        /// <summary>
        /// Computer's configuration information based on its building parts
        /// </summary>
        public abstract Dictionary<string, string> Configs
        {
            get;
        }
    }
}
