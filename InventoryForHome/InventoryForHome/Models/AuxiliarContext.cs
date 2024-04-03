using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InventoryForHome.Models
{
    public partial class InventoryForHomeContext : DbContext
    {
        public virtual DbSet<StoredProcedure1> StoredProcedure1s  { get; set; }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StoredProcedure1>(entity =>
            {
                entity.HasKey(e => e.IdItem);
                entity.Property(e => e.ItemName);
                entity.Property(e => e.Stock);
                entity.Property(e => e.TypePrioritaryName);
                entity.Property(e => e.TypeStockName);
                entity.Property(e => e.PurchesDate);
                entity.Property(e => e.ExpirationDate);
            }
            );
        }
    }
}
