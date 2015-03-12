using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod.GOF
{
    public class MailMainArea : MainArea
    {
        private readonly DataGridView _mainControl = new DataGridView();
 
        public override void Show()
        {
            this._mainControl.Show();
        }

        public override void Hide()
        {
            this._mainControl.Hide();
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
