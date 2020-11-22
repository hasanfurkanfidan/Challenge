using Hff.Challenge.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Challenge.DataAccess.Concrete.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(prop => prop.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Trademark).IsRequired();
        }
    }
}
