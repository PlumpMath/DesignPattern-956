using System.Collections.Generic;

namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    /// <summary>
    /// Known GeometryTool collection
    /// </summary>
    public class KnownGeometryToolCollection
    {
        /// <summary>
        /// All known geometry tools
        /// </summary>
        public static readonly List<GeometryTool> Tools = new List<GeometryTool>
            { 
                new CircleTool(),
                new CurveTool(),
                new DiamondTool(),
                new EllipseTool(),
                new HeartTool(),
                new RectangleTool(),
                new SquareTool(),
                new StraightTool(),
                new DownArrowTool(),
                new LeftArrowTool(),
                new RightArrowTool(),
                new UpArrowTool(),
                new HexagonTool(),
                new PentacleTool(),
                new PentagonTool(),
                new PolygonTool(),
                new RightTriangleTool(),
                new TriangleTool()
            };
    }
}
