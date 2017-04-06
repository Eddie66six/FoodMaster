using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Compra
{
    public class PedidoMap : EntityTypeConfiguration<Dominio.Compra.Entidade.Pedido>
    {
        public PedidoMap()
        {
            // Primary Key
            HasKey(t => t.IdPedido);

            // Properties
            Property(t => t.IdCliente).IsRequired();

            // Table & Column Mappings
            ToTable("Pedido");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
            HasRequired(t => t.Cliente)
                .WithMany(t => t.Pedidos)
                .HasForeignKey(d => d.IdCliente);
            HasOptional(t => t.FuncionarioEntregador)
                .WithMany(t => t.PedidosEntregues)
                .HasForeignKey(d => d.IdFuncionarioEntregador);
            HasOptional(t => t.FuncionarioCancelamento)
                .WithMany(t => t.PedidosCancelados)
                .HasForeignKey(d => d.IdFuncionarioCancelamento);
            HasOptional(t => t.FuncionarioPedido)
                .WithMany(t => t.PedidosFeito)
                .HasForeignKey(d => d.IdFuncionarioPedido);
            HasRequired(t => t.Filial)
                .WithMany(t => t.Pedidos)
                .HasForeignKey(d => d.IdFilial);
        }
    }
}