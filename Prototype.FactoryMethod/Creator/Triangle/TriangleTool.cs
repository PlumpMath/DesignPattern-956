
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class TriangleTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Triangle();
        }
    }
}
