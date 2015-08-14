
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class RectangleTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Rectangle();
        }
    }
}
