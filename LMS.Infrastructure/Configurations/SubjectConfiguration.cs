using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(subject => subject.Id);

            builder.Property(subject => subject.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(subject => subject.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Property(subject => subject.UpdatedAt)
                .IsRequired();

            builder.HasMany(subject => subject.Courses)
                .WithOne(course => course.Subject)
                .HasForeignKey(course => course.SubjectId)
                .OnDelete(DeleteBehavior.Cascade); ;
        }
    }
}
