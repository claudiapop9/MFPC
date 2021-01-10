using System.Collections.Generic;

namespace MfpcProject.Models
{
    public class Lot
    {
        public int Id { get; set; }
        public string LotNumber { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
