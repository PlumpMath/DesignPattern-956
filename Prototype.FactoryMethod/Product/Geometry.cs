using System.Drawing;
using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    /// <summary>
    /// Geometry base class
    /// </summary>
    public class Geometry
    {
        /// <summary>
        /// Initially, when users select a geometry tool such as a triangle tool, the tool will create a triangle of default size internally without drawing.
        /// And then when users press the mouse and start to draw the triangle, the Points will be changed accordingly, 
        /// and Draw() will be triggered and draw the geometry according to the Points.
        /// </summary>
        public List<Point> Points
        {
            protected get;  // External consumers just set Points and don't need to get Points
            set;            // Inernal code will get Points just for drawing purpose
        }

        public virtual void Draw()
        {
            // Code to draw the geometry according to its points
            // In the base class, we could do somthing like: drawing color / borders
        }
    }
}
