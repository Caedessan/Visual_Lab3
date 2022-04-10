namespace Visual_Lab3
{
    public class BusInfo
    {
        public string? Number { get; set; }
        public string? Type { get; set; }
        public string? Destination { get; set; }
        public string? DepartureDate { get; set; }
        public string? DepartureTime { get; set; }
        public string? ArrivalDate { get; set; }
        public string? ArrivalTime { get; set; }
    }
    internal static class Program
    {
        public static List<BusInfo> Buses = new List<BusInfo>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}