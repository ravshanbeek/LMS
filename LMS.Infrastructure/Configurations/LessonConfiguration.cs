using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(lesson => lesson.Id);

            builder.Property(lesson => lesson.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(lesson => lesson.CourseId)
                .IsRequired();

            builder.Property(lesson => lesson.Date)
                .IsRequired();

            builder.HasMany(lesson => lesson.NBs)
                .WithOne(nb => nb.Lesson);
        }
    }
}
