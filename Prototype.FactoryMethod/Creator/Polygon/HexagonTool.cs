
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class HexagonTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Hexagon();
        }
    }
}
