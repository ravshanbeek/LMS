using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(course => course.Id);

            builder.Property(course => course.Name)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(course => course.TeacherId)
                .IsRequired();

            builder.Property(course => course.SubjectId)
                .IsRequired();

            builder.HasMany(course => course.Lessons)
                .WithOne(lesson => lesson.Course);
        }
    }
}
