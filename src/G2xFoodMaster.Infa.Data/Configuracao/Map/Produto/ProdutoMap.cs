using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Produto
{
    public class ProdutoMap : EntityTypeConfiguration<Dominio.Produto.Entidade.Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            HasKey(t => t.IdProduto);

            // Properties
            Property(t => t.Descricao).IsRequired();

            // Table & Column Mappings
            ToTable("Produto");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
            HasRequired(t => t.FuncionarioCadastro)
                .WithMany(t => t.ProdutosCadastrados)
                .HasForeignKey(d => d.IdFuncionarioCadastro);
            HasRequired(t => t.FuncionarioCadastro)
                .WithMany(t => t.ProdutosCadastrados)
                .HasForeignKey(d => d.IdFuncionarioCadastro);
        }
    }
}