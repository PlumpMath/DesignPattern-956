
namespace TerrLuo.DesignPattern.Prototype.FactoryMethod
{
    public class CurveTool : GeometryTool
    {
        public override Geometry Create()
        {
            return new Curve();
        }
    }
}
