using Microsoft.EntityFrameworkCore;
using ModeloDB;
using System.Configuration;


namespace ConsolaApp
{
    public class CreditosDBBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria, MySql }
        static DBCreditos db;

        public static DBCreditos Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config
            string dbtipo = ConfigurationManager.AppSettings[DBTipo];
            string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;

            DbContextOptions<DBCreditos> contextOptions;

            switch (dbtipo)
            {
                case "SqlServer":
                    contextOptions = new DbContextOptionsBuilder<DBCreditos>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case "Postgres":
                    contextOptions = new DbContextOptionsBuilder<DBCreditos>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                case "MySql":
                    contextOptions = new DbContextOptionsBuilder<DBCreditos>()
                        .UseMySQL(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<DBCreditos>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new DBCreditos(contextOptions);

            return db;
        }
    }
}
