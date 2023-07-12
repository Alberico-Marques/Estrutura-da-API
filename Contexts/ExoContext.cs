using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
<<<<<<< HEAD
    public class ExoContext : DbContext
    {
        public ExoContext()
        { 
        }
        public ExoContext(DbContextOptions<ExoContext> options) : 
        base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)

        {
            if(!optionsBuilder.IsConfigured)
            {
            // Essa string de conexão depende da SUA máquina.
            optionsBuilder.UseSqlServer("Server=Andrey\\SQLEXPRESS;"+ "Database=ExoApi;User ID=sa;Password=12345;Trusted_Connection=False;");

            //("Server=Andrey\\SQLEXPRESS;"+ "Database=ExoApi;User ID=sa;Password=12345;Trusted_Connection=True;");
            // Exemplo 1 de string de conexão:
            // User
            //ID=sa;Password=Abc12345;Server=localhost;Database=ExoApi;-
            // + Trusted_Connection=False;
            // Exemplo 2 de string de conexão:
            //Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
=======
public class ExoContext : DbContext
{
public ExoContext()
{ 
}
public ExoContext(DbContextOptions<ExoContext> options) : 
base(options)
{
}
protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
{
if(!optionsBuilder.IsConfigured)
{
// Essa string de conexão depende da SUA máquina.
optionsBuilder.UseSqlServer("Server=ANDREY\\SQLEXPRESS;"
+ "Database=ExoApi;User ID=sa;Password=12345;Trusted_Connection=True;");
// Exemplo 1 de string de conexão:
// User
//ID=sa;Password=Abc12345;Server=localhost;Database=ExoApi;-
// + Trusted_Connection=False;
// Exemplo 2 de string de conexão:
// 
//Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;
}
}
public DbSet<Projeto> Projetos { get; set; }
}
>>>>>>> 7fd1bb56e36a51f88e7d7da797e8eaf4b42be3c3
}
