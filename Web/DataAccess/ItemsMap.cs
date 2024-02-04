using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.DataAccess
{
    public class ItemsMap : IEntityTypeConfiguration<items>
    {
        public void Configure(EntityTypeBuilder<items> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").UseIdentityAlwaysColumn().IsRequired();
            builder.Property(x => x.ItemName).HasColumnName("item_name").HasMaxLength(50).IsRequired();
            builder.Property(x => x.description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Price).HasColumnName("price").IsRequired();

            builder.ToTable("items", "public");
        }
    }
}