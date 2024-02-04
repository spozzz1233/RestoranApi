using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.DataAccess
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").UseIdentityAlwaysColumn().IsRequired();
            builder.Property(x => x.EmployeeName).HasColumnName("employee_name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.EmployeeSurnameName).HasColumnName("employee_surname").HasMaxLength(50).IsRequired();
            builder.Property(x => x.EmployeeMidName).HasColumnName("employee_midname").HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasColumnName("phone_number").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PassportNumber).HasColumnName("passport_number").HasMaxLength(10).IsRequired();
            builder.Property(x => x.DateOfBirth).HasColumnName("date_of_birth").HasMaxLength(10).IsRequired();
            builder.Property(x => x.Post).HasColumnName("post").HasMaxLength(10).IsRequired();
            builder.ToTable("employees", "public");
        }
    }
}
