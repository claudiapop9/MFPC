namespace MfpcProject.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int CalibratorId { get; set; }        
        public string Data { get; set; }

        public Department Department { get; set; }
        public Calibrator Calibrator { get; set; }
    }
}
