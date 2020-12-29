using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CategoriesTransactionConfiguration : IEntityTypeConfiguration<CategoriesTransaction>
    {

        public void Configure(EntityTypeBuilder<CategoriesTransaction> builder)
        {
            builder.ToTable("CategoriesTransactions");
            builder.HasKey(x => x.Id);
 
        }
    }
}
