using System;

using System.Windows.Forms;

namespace TerrLuo.DesignPattern.FactoryMethod
{
    public class CalendarWorkArea : WorkArea
    {
        private readonly ListView _areaControl = new ListView();
 
        public override void Show()
        {
            this._areaControl.Show();
        }

        public override void Hide()
        {
            this._areaControl.Hide();
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
