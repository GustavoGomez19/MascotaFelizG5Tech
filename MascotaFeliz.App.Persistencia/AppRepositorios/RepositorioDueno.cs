using System;
using System.Collections.Generic;
using System.Linq;
//Linq continen los objetos de tipo IEnumerable
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioDueno : IRepositorioDueno
    {
        /// <summary>
        /// Referencia al contexto de Dueno
        /// </summary>
        
        private readonly AppContext _appContext;
        //instanciar la clase AppContex, con el nombre de _appContext

        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        //<param name="appContext"></param>

        public RepositorioDueno(AppContext appContext)
        {//metodo constructor de RepositorioDueno
            _appContext = appContext;
        }

        public Dueno AddDueno(Dueno dueno)
        {
            var duenoAdicionado = _appContext.Duenos.Add(dueno);
            _appContext.SaveChanges();
            return duenoAdicionado.Entity;
        }

        public void DeleteDueno(int idDueno)
        {
            var duenoEncontrado = _appContext.Duenos.FirstOrDefault(d => d.Id == idDueno);
            if (duenoEncontrado == null)
                return;
            _appContext.Duenos.Remove(duenoEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Dueno> GetAllDuenos()
        {
            //Permite cargar todos los dueños que estan en la base de datos, y la añade a GetAllDuenos
            //de tipo IEnumerable<Dueno>
            return GetAllDuenos_();
        }

        public IEnumerable<Dueno> GetDuenosPorFiltro(string filtro)
        {
            var duenos = GetAllDuenos(); // Obtiene todos los saludos
            if (duenos != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    duenos = duenos.Where(s => s.Nombres.Contains(filtro));
                }
            }
            return duenos;
        }

        public IEnumerable<Dueno> GetAllDuenos_()
        {
            return _appContext.Duenos;
        }

        public Dueno GetDueno(int idDueno)
        {
            return _appContext.Duenos.FirstOrDefault(d => d.Id == idDueno);
        }

        public Dueno UpdateDueno(Dueno dueno)
        {
            var duenoEncontrado = _appContext.Duenos.FirstOrDefault(d => d.Id == dueno.Id);
            if (duenoEncontrado != null)
            {
                duenoEncontrado.Nombres = dueno.Nombres;
                duenoEncontrado.Apellidos = dueno.Apellidos;
                duenoEncontrado.Direccion = dueno.Direccion;
                duenoEncontrado.Telefono = dueno.Telefono;
                duenoEncontrado.Correo = dueno.Correo;
                _appContext.SaveChanges();
            }
            return duenoEncontrado;
        }     
    }
}