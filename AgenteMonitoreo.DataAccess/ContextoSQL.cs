using Microsoft.EntityFrameworkCore;

namespace AgenteMonitoreo.DataAccess
{
    public class ContextoSQL : DbContext
    {
        public DbSet<ControlDocumentosPorHora> ControlDocumentosPorHora { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\PRINCIPAL;Database=AgenteSQLExpress;User Id=sa;Password=DB*CONFI04/F;TrustServerCertificate=True;Encrypt=True;");
        }
    }
}
