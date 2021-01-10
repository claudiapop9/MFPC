using Microsoft.EntityFrameworkCore;

namespace MfpcProject.Models
{
    public class AdministrativeContext : DbContext
    {
        public AdministrativeContext(DbContextOptions options) : base(options)
        {

        }
    }
}
