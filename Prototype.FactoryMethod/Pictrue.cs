using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class Pictrue
    {
        /// <summary>
        /// Index of selected GeometryTool by users
        /// </summary>
        private int _selectedGeometryToolIndex = -1;

        /// <summary>
        /// Triggered when users select a GeometryTool
        /// </summary>
        /// <param name="selectedGeometryToolIndex"></param>
        protected void OnGeometryToolSelected(int selectedGeometryToolIndex)
        {
            // Record selected GeometryTool by users
            this._selectedGeometryToolIndex = selectedGeometryToolIndex;
        }

        /// <summary>
        /// Triggered when mouse pressing and dragging is finised
        /// </summary>
        /// <param name="beginPoint"></param>
        /// <param name="endPoint"></param>
        protected void OnMouseMoved(Point beginPoint, Point endPoint)
        {
            var geometryTool = KnownGeometryToolCollection.Tools[this._selectedGeometryToolIndex];
            var geometry = geometryTool.Create();

            var points = new List<Point> { beginPoint, endPoint };            
            geometry.Points = points;
            geometry.Draw();
        }
    }
}
