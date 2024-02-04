using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.DataAccess
{
    public class CustomerMap : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").UseIdentityAlwaysColumn().IsRequired();
            builder.Property(x => x.CustomersName).HasColumnName("customer_name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.CustomersSurName).HasColumnName("customer_surname").HasMaxLength(50).IsRequired();
            builder.Property(x => x.CustomersMidName).HasColumnName("customer_midname").HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.PhoneNumber).HasColumnName("phone_number").IsRequired();
            builder.ToTable("customers", "public");
        }
    }
}
