using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class ContactWorkArea : WorkArea
    {
        private readonly SplitContainer _areaControl = new SplitContainer();
 
        public override void Show()
        {
            this._areaControl.Show();
        }

        public override void Hide()
        {
            this._areaControl.Hide();
        }

        private void CreateContact()
        {
            // ...
        }

        private void EditContact()
        {
            // ...
        }
    }
}
