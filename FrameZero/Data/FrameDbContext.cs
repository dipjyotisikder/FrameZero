using FrameZero.Data.EntitiesConfiguration;
using FrameZero.Models;
using System.Data.Entity;

namespace FrameZero.Data
{
    public class FrameDbContext : DbContext
    {
        public FrameDbContext() { }

        public DbSet<Frame> Frames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations
            modelBuilder.Configurations.Add(new FrameConfiguration());
        }
    }
}