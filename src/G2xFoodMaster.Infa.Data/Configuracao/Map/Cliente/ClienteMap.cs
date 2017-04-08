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
            HasRequired(t => t.FuncionarioCadastro)
                .WithMany(t => t.ClientesCadastrados)
                .HasForeignKey(d => d.IdFuncionarioCadastro);
        }
    }
}