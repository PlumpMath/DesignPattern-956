
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class SquareTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Square();
        }
    }
}
