using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Estabelecimento
{
    public class FilialMap : EntityTypeConfiguration<Dominio.Estabelecimento.Entidade.Filial>
    {
        public FilialMap()
        {
            // Primary Key
            HasKey(t => t.IdFilial);

            // Properties
            Property(t => t.Nome).IsRequired();

            // Table & Column Mappings
            ToTable("Filial");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
            HasRequired(t => t.Estabelecimento)
                .WithMany(t => t.Filiais)
                .HasForeignKey(d => d.IdEstabelecimento);
        }
    }
}