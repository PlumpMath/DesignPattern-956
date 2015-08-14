
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class RightTriangleTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new RightTriangle();
        }
    }
}
