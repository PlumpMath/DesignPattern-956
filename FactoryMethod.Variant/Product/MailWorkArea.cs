using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.Variant
{
    public class MailWorkArea : WorkArea
    {
        private readonly DataGridView _areaControl = new DataGridView();
 
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
