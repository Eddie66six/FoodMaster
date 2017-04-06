using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Estabelecimento
{
    public class EstabelecimentoMap : EntityTypeConfiguration<Dominio.Estabelecimento.Entidade.Estabelecimento>
    {
        public EstabelecimentoMap()
        {
            // Primary Key
            HasKey(t => t.IdEstabelecimento);

            // Properties
            Property(t => t.Nome).IsRequired();

            // Table & Column Mappings
            ToTable("Estabelecimento");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
        }
    }
}