
namespace BusinessLogic.Entities
{
    public class LatLong
    {
        public decimal latitude;
        public decimal longitude;

        public LatLong(decimal latitude, decimal longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public decimal getLatitude()
        {
            return latitude;
        }
        public decimal getLongitude()
        {
            return longitude;
        }
    }
}
