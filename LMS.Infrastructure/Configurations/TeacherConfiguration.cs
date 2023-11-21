using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(teacher => teacher.Id);

            builder.Property(teacher => teacher.FullName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(teacher => teacher.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Property(teacher => teacher.UpdatedAt)
                .IsRequired();

            builder.Property(teacher => teacher.Birthdate)
                .IsRequired();

            builder.Property(teacher => teacher.Gender)
                .IsRequired();

            builder.Property(teacher => teacher.Address)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(teacher => teacher.Username)
                .HasMaxLength(50);

            builder.Property(teacher => teacher.AddressTemporary)
                .IsRequired();

            builder.HasMany(teacher => teacher.Courses)
               .WithOne(course => course.Teacher)
               .HasForeignKey(course => course.TeacherId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
