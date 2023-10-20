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
                .IsRequired();

            builder.HasMany(subject => subject.Courses)
                .WithOne(course => course.Subject)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
