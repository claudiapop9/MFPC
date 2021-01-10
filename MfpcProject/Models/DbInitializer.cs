using System.Linq;

namespace MfpcProject.Models
{
    public class DbInitializer
    {
        public static void Initialize(FarmaContext context)
        {
            context.Database.EnsureCreated();

            var calibrators = new Calibrator[]
            {
                new Calibrator{ Value = "calibrator1", Unit ="mL" },
                new Calibrator{ Value = "calibrator2", Unit ="L" },
                new Calibrator{ Value = "calibrator3", Unit ="dm" },
            };

            context.Calibrators.AddRange(calibrators);
            context.SaveChanges();

            var deparments = new Department[]
            {
                new Department{Name = "Production", Country = "RO" },
                new Department{Name = "Test", Country = "RO" },
                new Department{Name = "Production", Country = "DE" },
                new Department{Name = "Test", Country = "DE" },
            };

            context.Departments.AddRange(deparments);
            context.SaveChanges();

            var applications = new Application[]
            {
                new Application{CalibratorId = calibrators[0].Id, DepartmentId = deparments[0].Id, Data ="app1" },
                new Application{CalibratorId = calibrators[1].Id, DepartmentId = deparments[1].Id, Data ="app2" },
                new Application{CalibratorId = calibrators[2].Id, DepartmentId = deparments[2].Id, Data ="app3" },
            };

            context.Applications.AddRange(applications);
            context.SaveChanges();

            var lots = new Lot[]
            {
                new Lot { LotNumber="111111" },
                new Lot { LotNumber="222222" },
            };

            context.Lots.AddRange(lots);
            context.SaveChanges();
        }
    }
}
