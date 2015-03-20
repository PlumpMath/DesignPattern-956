using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class CalendarWorkArea : WorkArea
    {
        private readonly System.Windows.Forms.ListView _container = new ListView();
 
        public override void Show()
        {
            this._container.Show();
        }

        public override void Hide()
        {
            this._container.Hide();
        }

        private void CreateMeeting()
        {
            // ...
        }

        private void CreateAppointment()
        {
            // ...
        }

        private void Accept()
        {
            // ...
        }

        private void Tentative()
        {
            // ...
        }

        private void Decline()
        {
            // ...
        }
    }
}
