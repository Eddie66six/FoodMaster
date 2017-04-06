using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Compra
{
    public class RecebimentoItemMap : EntityTypeConfiguration<Dominio.Compra.Entidade.RecebimentoItem>
    {
        public RecebimentoItemMap()
        {
            // Primary Key
            HasKey(t => t.IdRecebimentoItem);

            // Properties
            Property(t => t.IdPedidoItem).IsRequired();

            // Table & Column Mappings
            ToTable("RecebimentoItem");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
            HasRequired(t => t.PedidoItem)
                .WithMany()
                .HasForeignKey(t => t.IdPedidoItem);
        }
    }
}