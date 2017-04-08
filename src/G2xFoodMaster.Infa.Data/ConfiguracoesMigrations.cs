using System.Data.Entity.Migrations;

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
