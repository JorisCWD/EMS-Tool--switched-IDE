using Microsoft.AspNetCore.Mvc;

namespace EMS_Tool.Model
{
    public class Chart
    {
        public int ID { get; set; }
        public int NavID { get; set; }
        public string ChartTitle { get; set; }
        public string DataQuery { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string ChartType { get; set; }

        public Navbar Navbar { get; set; }
    }

}
