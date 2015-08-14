
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class CircleTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Circle();
        }
    }
}
