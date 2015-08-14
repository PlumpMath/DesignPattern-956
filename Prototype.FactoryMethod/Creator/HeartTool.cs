
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class HeartTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Heart();
        }
    }
}
