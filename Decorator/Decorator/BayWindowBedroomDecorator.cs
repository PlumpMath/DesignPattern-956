using System;

namespace TerrLuo.DesignPattern.Decorator
{
    /// <summary>
    /// 飘窗
    /// </summary>
    public class BayWindowBedroomDecorator : BedroomDecorator
    {
        private readonly Bedroom _bedroom;

        public BayWindowBedroomDecorator(Bedroom bedroom)
        {
            this._bedroom = bedroom;
        }

        public override void Show3DPic()
        {
            // Do the operation of decorating bedroom
            this._bedroom.Show3DPic();

            // Do the opertion of itself
            ShowBayWindow();
        }

        private void ShowBayWindow()
        {
            // ...
        }
    }
}
