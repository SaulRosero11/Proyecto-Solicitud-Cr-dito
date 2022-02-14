using System;
using Microsoft.EntityFrameworkCore;
using Proceso;

namespace ConsolaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grabar grabar = new Grabar();
            grabar.DatosIni();

            using (var db = CreditosDBBuilder.Crear())
            {
                var listaSoli = db.Solicitantes
                    .Include(solici => solici.Afiliado)
                    ;

                Console.WriteLine("Listado de Solicitantes");
                foreach (var solici in listaSoli)
                {
                    Console.WriteLine(
                        solici.Nombres + " " +
                        solici.Apellidos + " " +
                        solici.Afiliado.AfiliadoId + " " +
                        solici.Afiliado.NombreEmpresa + " " +
                        solici.Afiliado.TotalAportaciones
                    );
                }

                ProValidacion pro = new ProValidacion(db);

                var resultado = pro.ValidarCredito(3);

                Console.WriteLine(resultado);
                    


            }
        }
    }
}
