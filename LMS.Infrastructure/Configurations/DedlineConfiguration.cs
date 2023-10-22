using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class DedlineConfiguration : IEntityTypeConfiguration<Deadline>
    {
        public void Configure(EntityTypeBuilder<Deadline> builder)
        {
            builder.HasKey(dedline => dedline.Id);

            builder.Property(dedline => dedline.MaxGrade)
                .IsRequired();

            builder.Property(dedline => dedline.CreatedDate)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);
            
            builder.Property(dedline => dedline.StartDate)
                .IsRequired();
            
            builder.Property(dedline => dedline.ExpiredDate)
                .IsRequired();

            builder.HasMany(dedline => dedline.Grades)
                .WithOne(grade => grade.Deadline)
                .HasForeignKey(grade => grade.DedlineId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
