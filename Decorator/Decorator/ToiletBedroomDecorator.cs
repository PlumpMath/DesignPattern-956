using System;

namespace TerrLuo.DesignPattern.Decorator
{
    /// <summary>
    /// 卫生间
    /// </summary>
    public class ToiletBedroomDecorator : BedroomDecorator
    {
        private readonly Bedroom _bedroom;

        public ToiletBedroomDecorator(Bedroom bedroom)
        {
            this._bedroom = bedroom;
        }

        public override void Show3DPic()
        {
            // Do the operation of decorating bedroom
            this._bedroom.Show3DPic();

            // Do the opertion of itself
            ShowToilet();
        }

        private void ShowToilet()
        {
            // ...
        }
    }
}
