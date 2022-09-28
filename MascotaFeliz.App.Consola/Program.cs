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
            Console.WriteLine("Inicio de trabajo con las tablas de la BD");

            //AddDueno();
            //BuscarDueno();
            //ListarDuenos();
            //AsignarDueno();
            //ListarDuenosFiltro();

            //AddVeterinario();
            //BuscarVeterinario();
            //ListarVeterinarios();
            //AsignarVeterinario();
            //ListarVeterinariosFiltro();
            
            //AddMascota();
            //BuscarMascota(1);
            //ListarMascotas();
            //AsignarVisitaPyP(1);
            //AddHistoria();
            //AsignarHistoria();

        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Katerine",
                Apellidos = "Gil",
                Direccion = "Calle 5 # 3 - 11",
                Telefono = "3178554617",
                Correo = "kategil@gmail.com"
            };
            dueno = _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Moises",
                Apellidos = "Gómez",
                Direccion = "Calle 71a # 19 - 95",
                Telefono = "1234567891",
                TarjetaProfesional = "TP00002"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Gael",
                Color = "Cafe/Blanco",
                Especie = "Felino",
                Raza = "Criollo",
            };
            _repoMascota.AddMascota(mascota);
        }

        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaVisita = new DateTime(2020, 01, 01)
            };
            _repoHistoria.AddHistoria(historia);
        }

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
            }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(" " + veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " " + veterinario.Telefono + " " + veterinario.TarjetaProfesional);
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(" " + mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza + " " + mascota.Dueno.Nombres);
        }

        private static void ListarDuenosFiltro()
        {
            var duenosM = _repoDueno.GetDuenosPorFiltro("Ped");
            foreach (Dueno p in duenosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre + " " + m.Raza + " le pertenece a " + m.Dueno.Nombres + " " + m.Dueno.Apellidos+ " y lo atiende " + m.Veterinario.Nombres);
            }
        }

        private static void ListarHistorias()
        {
            var historias = _repoHistoria.GetAllHistorias();
            foreach (Historia h in historias)
            {
                Console.WriteLine(h.Id + " Este es el id de la historia");
            }
        }

        
//dueno.Cedula + " " + 

        private static void ListarVeterinariosFiltro()
        {
            var veterinariosM = _repoVeterinario.GetVeterinariosPorFiltro("e");
            foreach (Veterinario p in veterinariosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        
        //Asignar veterinario a mascota
        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(1, 3);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        //Asignar dueño a mascota
        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(1, 1);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        //Asignar historia a mascota
        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(1, 1);
        }
        
    }
}
