
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class PolygonTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Polygon();
        }
    }
}
