using Corretores.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Corretores.Repository
{
    public class Contexto: DbContext
    {
        public static IConfigurationRoot Configuration { get; set; }
        public bool UseLazyLoading { get; set; }

        public Contexto()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=" + Configuration["Servidor"] + ";Initial Catalog=" + Configuration["Banco"] + ";User ID=sa;PWD=;MultipleActiveResultSets=True");
        }
        public DbSet<CorretorEntity> Corretor { get; set; }
    }
}
