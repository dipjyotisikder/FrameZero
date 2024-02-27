using FrameZero.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FrameZero.Data.EntitiesConfiguration
{
    internal class FrameConfiguration : EntityTypeConfiguration<Frame>
    {
        public FrameConfiguration()
        {
            ToTable("Frame");

            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
