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
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(student => student.Gender)
                .IsRequired();

            builder.Property(student => student.Address)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(student => student.GroupId)
                .IsRequired();
        }
    }
}
