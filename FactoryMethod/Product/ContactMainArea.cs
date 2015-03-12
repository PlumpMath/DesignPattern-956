using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.GOF
{
    public class ContactMainArea : MainArea
    {
        private readonly SplitContainer _mainControl = new SplitContainer();
 
        public override void Show()
        {
            this._mainControl.Show();
        }

        public override void Hide()
        {
            this._mainControl.Hide();
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
