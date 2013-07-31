using System.Data.Entity;


namespace MasterDetail.Models
{
    public class MasterDetailContext :DbContext
    {
        public MasterDetailContext(): base("MasterDetailContext")
        {
        }

        public DbSet<SalesMain> SalesMains { get; set; }
        public DbSet<SalesSub> SalesSubs { get; set; }
    }
    
}
