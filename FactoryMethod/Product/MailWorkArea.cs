using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class MailWorkArea : WorkArea
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

        private void CreateNewMail()
        {
            // ...
        }

        private void ReplyMail()
        {
            // ...
        }

        private void ForwardMail()
        {
            // ...
        }
    }
}
