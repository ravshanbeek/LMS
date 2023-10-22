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

            builder.HasMany(course => course.Lessons)
                .WithOne(lesson =>lesson.Course)
                .HasForeignKey(lesson => lesson.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasMany(course => course.Deadlines)
                .WithOne(dedline => dedline.Course)
                .HasForeignKey(dedline => dedline.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(course => course.Groups)
                .WithMany(group => group.Courses);
        }
    }
}
