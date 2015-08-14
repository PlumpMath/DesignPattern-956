
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class RightArrowTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new RightArrow();
        }
    }
}
