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
                .IsRequired();
          
            builder.Property(teacher => teacher.Birthdate)
                .IsRequired();
         
            builder.Property(teacher => teacher.Gender)
                .IsRequired();
            
            builder.Property(teacher => teacher.Address)
                .IsRequired();
            
            builder.Property(teacher => teacher.AddressTemporary)
                .IsRequired();

            builder.HasMany(teacher => teacher.Courses)
               .WithOne(course => course.Teacher)
               .HasForeignKey(course => course.TeacherId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
