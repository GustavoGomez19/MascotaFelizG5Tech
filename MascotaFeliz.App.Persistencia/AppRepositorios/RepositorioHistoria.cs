using System;
using System.Collections.Generic;
using System.Linq;
//Linq continen los objetos de tipo IEnumerable
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
        /// <summary>
        /// Referencia al contexto de Historia
        /// </summary>
        
        private readonly AppContext _appContext;
        //instanciar la clase AppContex, con el nombre de _appContext

        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        //<param name="appContext"></param>

        public RepositorioHistoria(AppContext appContext)
        {//metodo constructor de RepositorioHistoria
            _appContext = appContext;
        }

        public Historia AddHistoria(Historia historia)
        {
            var historiaAdicionado = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;
        }

        public void DeleteHistoria(int idHistoria)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
            if (historiaEncontrado == null)
                return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Historia> GetAllHistorias()
        {
            //Permite cargar todos los dueños que estan en la base de datos, y la añade a GetAllHistorias
            //de tipo IEnumerable<Historia>
            return GetAllHistorias_();
        }

        /*public IEnumerable<Historia> GetHistoriasPorFiltro(string filtro)
        {
            var historias = GetAllHistorias(); // Obtiene todos los saludos
            if (historias != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    historias = historias.Where(s => s.Nombres.Contains(filtro));
                }
            }
            return historias;
        }*/

        public IEnumerable<Historia> GetAllHistorias_()
        {
            return _appContext.Historias;
        }

        public Historia GetHistoria(int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(h => h.Id == idHistoria);
        }

        public Historia UpdateHistoria(Historia historia)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(h => h.Id == historia.Id);
            if (historiaEncontrado != null)
            {
                historiaEncontrado.FechaInicial = historia.FechaInicial;
                _appContext.SaveChanges();
            }
            return historiaEncontrado;
        }     
    }
}