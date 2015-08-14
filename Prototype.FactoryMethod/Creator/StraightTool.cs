
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class StraightTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Straight();
        }
    }
}
