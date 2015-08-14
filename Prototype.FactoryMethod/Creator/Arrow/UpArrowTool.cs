
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class UpArrowTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new UpArrow();
        }
    }
}
