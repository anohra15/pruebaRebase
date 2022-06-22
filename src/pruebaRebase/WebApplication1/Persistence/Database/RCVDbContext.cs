//using System.Data.E;
using backendRCVUcab.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace backendRCVUcab.Persistence.Database
{
    public class RCVDbContext:DbContext, IRCVDbContext
    {
        public RCVDbContext() {}
        
        public RCVDbContext(DbContextOptions<RCVDbContext> options):base(options) {}
        
        public DbContext DbContext
        {
            get
            {
                return this;
            }
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Generar un uuid cuando creas un registro en una entidad
            //inicio
            modelBuilder.HasPostgresExtension("uuid-ossp");
            
            //Entidad CotizacionTallerEntity
            modelBuilder.Entity<CotizacionTallerEntity>()
                .Property(cotizacion => cotizacion.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")    // Use 
                .IsRequired();
            //Entidad OrdenCompraEntity
            modelBuilder.Entity<OrdenCompraEntity>()
                .Property(ordenCompra => ordenCompra.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")    // Use 
                .IsRequired();
            //Entidad TallererEntity
            modelBuilder.Entity<TallererEntity>()
                .Property(tallerEntity => tallerEntity.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")    // Use 
                .IsRequired();
            //Fin

            //UUID 
            //Inicio
            modelBuilder.Entity<CotizacionTallerEntity>()
                .Property(cotizacion => cotizacion.usuario_taller)
                .IsUnicode(true);
            //Fin
        }*/

        /*
         public virtual Microsoft.EntityFrameworkCore.DbSet<TallererEntity> Talleres
        {
            get; set;
        }
         
         public virtual Microsoft.EntityFrameworkCore.DbSet<MarcaCarroEntity> Marcas
         {
             get; set;
         }

         public virtual Microsoft.EntityFrameworkCore.DbSet<TelefonoEntity> Telefonos
         {
             get; set;
         }
         
         public virtual Microsoft.EntityFrameworkCore.DbSet<CotizacionTallerEntity> Cotizaciones
         {
             get; set;
         }
         
         public virtual Microsoft.EntityFrameworkCore.DbSet<OrdenCompraEntity> OrdenesCompras
         {
             get; set;
         }*/

         
        

        
        
    }
}