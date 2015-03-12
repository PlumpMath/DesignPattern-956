using System;

namespace TerrLuo.DesignPattern.Decorator
{
    /// <summary>
    /// 衣帽间
    /// </summary>
    public class CloakRoomBedroomDecorator : BedroomDecorator
    {
        private readonly Bedroom _bedroom;

        public CloakRoomBedroomDecorator(Bedroom bedroom)
        {
            this._bedroom = bedroom;
        }

        public override void Show3DPic()
        {
            // Do the operation of decorating bedroom
            this._bedroom.Show3DPic();

            // Do the opertion of itself
            ShowCloakRoom();
        }

        private void ShowCloakRoom()
        {
            // ...
        }
    }
}
