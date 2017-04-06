using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using G2xFoodMaster.Dominio.Cliente.Entidade;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Funcionario.Entidade;
using G2xFoodMaster.Dominio.Produto.Entidade;
using G2xFoodMaster.Infa.Data.Configuracao.Map.Cliente;
using System.Linq;
using G2xFoodMaster.Infa.Data.Configuracao.Map.Compra;
using G2xFoodMaster.Infa.Data.Configuracao.Map.Estabelecimento;
using G2xFoodMaster.Infa.Data.Configuracao.Map.Funcionario;
using G2xFoodMaster.Infa.Data.Configuracao.Map.Produto;

namespace G2xFoodMaster.Infa.Data.Configuracao
{
    public class DataContext : DbContext
    {
        public DataContext() : base("foodMaster")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<RecebimentoItem> RecebimentoItem { get; set; }
        public DbSet<Estabelecimento> Estabelecimento { get; set; }
        public DbSet<Filial> Filial { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Properties()
            //       .Where(p => p.Name == "Id" + p.ReflectedType?.Name)
            //       .Configure(p => p.IsKey());
            modelBuilder.Properties<string>()
                   .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                  .Configure(p => p.HasMaxLength(100));

            #region map
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new PedidoMap());
            modelBuilder.Configurations.Add(new PedidoItemMap());
            modelBuilder.Configurations.Add(new RecebimentoItemMap());
            modelBuilder.Configurations.Add(new EstabelecimentoMap());
            modelBuilder.Configurations.Add(new FilialMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            #endregion
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataDeCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataDeCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataDeCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}