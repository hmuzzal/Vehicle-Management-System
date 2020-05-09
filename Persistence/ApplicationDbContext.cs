using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Persistence
{
    public class ApplicationDbContext:DbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options)
        {
            
        }


        
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> models{get;set;}


    }
}