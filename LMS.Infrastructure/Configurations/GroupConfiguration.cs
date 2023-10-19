using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(group => group.Id);

        builder.Property(group => group.Name)
            .HasMaxLength(20)
            .IsRequired(true);

        builder.Property(group => group.Level)
            .HasDefaultValue(1);

        builder.HasMany(group => group.Students)
            .WithOne()
            .HasForeignKey(student => student.GroupId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(group => group.Courses)
            .WithMany();
    }
}
