using Microsoft.EntityFrameworkCore;


namespace TodoApi.Models
{
    public class UbharaContext : DbContext
    {
        public UbharaContext(DbContextOptions<UbharaContext> options)
            : base(options)
            
        public DbSet<JurusanList> JurusanLists { get; set; } 
        public DbSet<KelasList> KelasLists { get; set; } 
        public DbSet<SiswaList> SiswaLists { get; set; } 
    }
}