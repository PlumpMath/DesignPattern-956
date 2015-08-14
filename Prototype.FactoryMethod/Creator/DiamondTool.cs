
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class DiamondTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Diamond();
        }
    }
}
