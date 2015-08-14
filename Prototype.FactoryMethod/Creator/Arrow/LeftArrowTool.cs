
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class LeftArrowTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new LeftArrow();
        }
    }
}
