﻿using System.Data.Entity.ModelConfiguration;

namespace G2xFoodMaster.Infa.Data.Configuracao.Map.Funcionario
{
    public class FuncionarioMap : EntityTypeConfiguration<Dominio.Funcionario.Entidade.Funcionario>
    {
        public FuncionarioMap()
        {
            // Primary Key
            HasKey(t => t.IdFuncionario);

            // Properties
            Property(t => t.Nome).IsRequired();

            // Table & Column Mappings
            ToTable("Funcionario");
            //Property(t => t.IdCliente).HasColumnName("Cliente");

            // Relationships
            HasOptional(t => t.FuncionarioCadastro)
                .WithMany(t => t.FuncionarioCadastrados)
                .HasForeignKey(d => d.IdFuncionarioCadastro);
            HasRequired(t => t.Filial)
                .WithMany(t => t.FuncionariosCadastrados)
                .HasForeignKey(d => d.IdFilial);
        }
    }
}