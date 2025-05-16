using Microsoft.AspNetCore.Mvc;

namespace EMS_Tool.Model
{
    public class Navbar
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Sequence { get; set; }

        public ICollection<Chart> Charts { get; set; }
    }

}
