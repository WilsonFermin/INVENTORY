
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class InventaryContex : DbContext
    {
        public DbSet<ProductEntity> Products {get; set;}
        public DbSet<CategoryEntity> Categories {get; set;}
        public DbSet<InputOutputEntity> InOuts {get; set;}
        public DbSet<WarehouseEntity> Warehouses {get; set;} 
        public DbSet<StorageEntity> Storages {get; set;}
  
    }
}
