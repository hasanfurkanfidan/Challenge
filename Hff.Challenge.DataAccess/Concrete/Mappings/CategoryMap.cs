using Hff.Challenge.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.DataAccess.Concrete.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(c => c.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired();

            builder.HasMany(p => p.Products).WithOne(prop => prop.Category).HasForeignKey(prop => prop.CategoryId);

        }
    }
}
