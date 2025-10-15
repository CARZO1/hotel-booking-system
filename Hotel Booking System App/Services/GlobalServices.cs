using HotelBookingSystem.Services;

namespace HotelBookingSystem
{
    public static class GlobalServices
    {
        // A single shared BookingService for the whole app
        internal static BookingService BookingService { get; } = new BookingService();
    }
}
