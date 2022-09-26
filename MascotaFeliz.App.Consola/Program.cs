using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
           //AddDueno();
           //ListarDuenos();
           //AddVeterinario();
           //ListarVeterinarios();
            //AddMascota();
            //ListarMascotas();
            AsignarVeterinario();
            AsignarDueno();
            //AddHistoria();
            //AsignarVisitaPyP(1);
            AsignarHistoria();
        }
        //************************************ CREAR OBJETOS**************************
        /*private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Mario",
                Apellidos = "Rojas",
                Direccion = "Cra 90-56 ",
                Telefono = "1234567891",
                Correo = "Mario@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
        */
        /*private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "ol",
                Apellidos = "Rojas",
                Direccion = "Cra 90-56 ",
                Telefono = "1234567891",
                TarjetaProfesional="1234",
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        */
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "lupita",
                Color = "blanca",
                Especie = "Canino",
                Raza= "Criolla",
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial=Convert.ToDateTime("2020-01-01"),
            };
            _repoHistoria.AddHistoria(historia);
        }

        //*********************************************************METODOS****************
            private static void BuscarDueno(int idDueno)
            {
             var dueno = _repoDueno.GetDueno(idDueno);
                Console.WriteLine(" " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
            }
             //--------------------------------------------------------------------------
            private static void ListarDuenos()
            {
                var duenos = _repoDueno.GetAllDuenos();
                foreach (Dueno d in duenos)
                {  
                 Console.WriteLine(d.Nombres + " " + d.Apellidos);
                }
            }
            //--------------------------------------------------------------------------
            private static void BuscarVeterinario(int idVeterinario)
            {
             var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
                Console.WriteLine(" " + veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " " + veterinario.Telefono + " " + veterinario.TarjetaProfesional);
            }
             //--------------------------------------------------------------------------
            private static void ListarVeterinarios()
            {
                var veterinarios = _repoVeterinario.GetAllVeterinarios();
                foreach (Veterinario v in veterinarios)
                {  
                 Console.WriteLine(v.Nombres + " " + v.Apellidos);
                }
            }
            //--------------------------------------------------------------------------
            
            private static void AsignarVeterinario()
            {
            var veterinario = _repoMascota.AsignarVeterinario(2, 4);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
            }
            //----------------------------------------------------------------------------
            
            private static void BuscarMascota(int idMascota)
            {
             var mascota = _repoMascota.GetMascota(idMascota);
                Console.WriteLine(" " + mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza );
            }
            //--------------------------------------------------------------------------
            private static void ListarMascotas()
            {
                var mascotas = _repoMascota.GetAllMascotas();
                foreach (Mascota v in mascotas)
                {  
                 Console.WriteLine(v.Nombre+ " " + v.Especie);
                }
            }
            //--------------------------------------------------------------------------
            private static void AsignarVisitaPyP(int idHistoria)
            {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 4, Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 4, Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
            else
            {
                Console.WriteLine("La visita no existe");
            }
            }
            
            //--------------------------------------------------------------------------
             private static void AsignarDueno()
            {
            var dueno = _repoMascota.AsignarDueno(2, 3);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
            }
            //--------------------------------------------------------------------------
             private static void AsignarHistoria()
            {
            var historia = _repoMascota.AsignarHistoria(2, 1);
            Console.WriteLine("Fecha historia "+ historia.FechaInicial);
            }

            
    }
}
