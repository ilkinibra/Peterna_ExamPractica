using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Paterna_Backend.Models;

namespace Paterna_Backend.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<PageIntro> pageIntros { get; set; }
        public DbSet<Services> services { get; set; }
        public DbSet<ServicesCard> servicesCards { get; set; }  
        public DbSet<Plan> plans { get; set; }
        public DbSet<PlanCard> planCards { get; set; }
    }
}
