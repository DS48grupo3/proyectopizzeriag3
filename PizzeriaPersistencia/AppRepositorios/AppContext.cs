using Microsoft.EntityFrameworkCore;
using PizzeriaDominio;

namespace PizzeriaPersistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Tb_cliente{get; set;}
        public DbSet<Producto> Tb_producto{get; set;}
        public DbSet<Pedido> Tb_pedido{get; set;}
         public DbSet<Carrito> Tb_carrito{get; set;}  

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PizzaTech");
            }
         }
    }
}