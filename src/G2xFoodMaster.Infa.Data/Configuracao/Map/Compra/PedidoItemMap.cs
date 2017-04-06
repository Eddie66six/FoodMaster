using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Compra
{
    public class PedidoItemMap : EntityTypeConfiguration<Dominio.Compra.Entidade.PedidoItem>
    {
        public PedidoItemMap()
        {
            // Primary Key
            HasKey(t => t.IdPedidoItem);

            // Properties
            Property(t => t.IdProduto).IsRequired();
            Property(t => t.IdPedido).IsRequired();

            // Table & Column Mappings
            ToTable("PedidoItem");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
            HasRequired(t => t.Pedido)
                .WithMany(t => t.ItensDoPedido)
                .HasForeignKey(d => d.IdPedido);
            HasRequired(t => t.Produto)
                .WithMany(t => t.PedidoItems)
                .HasForeignKey(d => d.IdProduto);
            HasRequired(t => t.RecebimentoItem)
                .WithMany()
                .HasForeignKey(t => t.IdRecebimentoItem);
        }
    }
}