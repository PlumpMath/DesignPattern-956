
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class EllipseTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Ellipse();
        }
    }
}
