using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(student => student.Id);

            builder.Property(student => student.FullName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(student => student.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Property(student => student.UpdatedAt)
                .IsRequired();

            builder.Property(student => student.Gender)
                .IsRequired();

            builder.Property(student => student.Address)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(student => student.Username)
                .HasMaxLength(50);

            builder.Property(student => student.GroupId)
                .IsRequired();
        }
    }
}
