using System;
using System.Data.Entity.Migrations;
using G2xFoodMaster.Dominio.Cliente.Entidade;
using G2xFoodMaster.Dominio.Compra.Entidade;
using G2xFoodMaster.Dominio.Compra.Enum;
using G2xFoodMaster.Dominio.Estabelecimento.Entidade;
using G2xFoodMaster.Dominio.Funcionario.Entidade;
using G2xFoodMaster.Dominio.Produto.Entidade;
using G2xFoodMaster.Dominio._Comun.Entidade;

namespace G2xFoodMaster.Infa.Data
{
    public class ConfiguracoesMigrations : DbMigrationsConfiguration<Configuracao.DataContext>
    {
        public ConfiguracoesMigrations()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Configuracao.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
