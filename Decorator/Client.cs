using System;

namespace TerrLuo.DesignPattern.Decorator
{
    public class Client
    {
        /// <summary>
        /// BayWindow( ClockRoom ( Toilet ( Bedroom ) ) )
        /// </summary>
        /// <returns></returns>
        public Bedroom CreateBarWindowCloakRoomToiletBedroom()
        {
            var bedroom = new SimpleBedroom();
            var toiletBedroom = new ToiletBedroomDecorator(bedroom);
            var cloakRoomToiletBedroom = new CloakRoomBedroomDecorator(toiletBedroom);
            var barWindowCloakRoomToiletBedroom = new BayWindowBedroomDecorator(cloakRoomToiletBedroom);
            return barWindowCloakRoomToiletBedroom;
        }

        /// <summary>
        /// ClockRoom ( Toilet ( Bedroom ) ) )
        /// </summary>
        /// <returns></returns>
        public Bedroom CreateCloakRoomToiletBedroom()
        {
            var bedroom = new SimpleBedroom();
            var toiletBedroom = new ToiletBedroomDecorator(bedroom);
            var cloakRoomToiletBedroom = new CloakRoomBedroomDecorator(toiletBedroom);
            return cloakRoomToiletBedroom;
        }

        /// <summary>
        /// BayWindow( ClockRoom ( Bedroom ) )
        /// </summary>
        /// <returns></returns>
        public Bedroom CreateBayWindowCloakRoomBedroom()
        {
            var bedroom = new SimpleBedroom();
            var cloakRoomBedroom = new CloakRoomBedroomDecorator(bedroom);
            var barWindowCloakRoomBedroom = new BayWindowBedroomDecorator(cloakRoomBedroom);
            return barWindowCloakRoomBedroom;
        }
    }
}
