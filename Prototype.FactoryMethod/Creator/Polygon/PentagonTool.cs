
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class PentagonTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Pentagon();
        }
    }
}
