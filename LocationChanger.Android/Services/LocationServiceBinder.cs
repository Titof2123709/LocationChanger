using Android.OS;

namespace LocationChanger.Android.Services
{
    public class LocationServiceBinder : Binder
    {
        protected LocationService service;
        public LocationService Service => service;

        public bool IsBound { get; set; }

        public LocationServiceBinder(LocationService service)
        {
            this.service = service;
        }
    }
}