
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class PentacleTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Pentacle();
        }
    }
}
