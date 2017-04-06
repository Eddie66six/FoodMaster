using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Cliente
{
    public class ClienteMap : EntityTypeConfiguration<Dominio.Cliente.Entidade.Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            HasKey(t => t.IdCliente);

            // Properties
            Property(t => t.Nome).IsRequired();

            // Table & Column Mappings
            ToTable("Cliente");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
            //this.HasOptional(t => t.Pedidos)
            //    .WithMany(t => t.)
            //    .HasForeignKey(d => d.IdLog);
        }
    }
}