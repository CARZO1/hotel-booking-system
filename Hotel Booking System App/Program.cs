using System;
using System.Windows.Forms;
using HotelBookingSystem.Forms;

namespace HotelBookingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm()); // use LoginForm as the startup form
        }
    }
}
