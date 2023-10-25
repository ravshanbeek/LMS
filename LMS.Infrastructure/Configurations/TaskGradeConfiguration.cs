using LMS.Domen.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LMS.Infrastructure.Configurations
{
    public class TaskGradeConfiguration : IEntityTypeConfiguration<TaskGrade>
    {
        public void Configure(EntityTypeBuilder<TaskGrade> builder)
        {
            builder.HasKey(taskGrade => taskGrade.Id);

            builder.Property(taskGrade => taskGrade.CreatedAt)
             .HasDefaultValue(DateTime.Now);

            builder.Property(taskGrade => taskGrade.UpdatedAt)
                .IsRequired();

            builder.Property(taskGrade => taskGrade.DedlineId)
                .IsRequired();

            builder.Property(taskGrade => taskGrade.StudentId)
                .IsRequired();

            builder.Property(taskGrade => taskGrade.GradeValue)
                .HasDefaultValue(0);
        }
    }
}
