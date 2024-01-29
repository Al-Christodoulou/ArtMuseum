using Ergasia3.src;
using Ergasia3.src.Frontend.CinemaHall;
using Ergasia3.src.Frontend.ConcertHall;
using Ergasia3.src.Frontend.ExhibitionHall;
using Ergasia3.src.Frontend.DJHall;
using Ergasia3.src.Frontend;

namespace Ergasia3.src
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainHall());
        }
    }
}