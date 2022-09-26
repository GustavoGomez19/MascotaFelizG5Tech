using System;
using System.Collections.Generic;
using System.Linq;
//Linq continen los objetos de tipo IEnumerable
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP : IRepositorioVisitaPyP
    {
        /// <summary>
        /// Referencia al contexto de VisitaPyP
        /// </summary>
        
        private readonly AppContext _appContext;
        //instanciar la clase AppContex, con el nombre de _appContext

        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>

        //<param name="appContext"></param>

        public RepositorioVisitaPyP(AppContext appContext)
        {//metodo constructor de RepositorioVisitaPyP
            _appContext = appContext;
        }

        public VisitaPyP AddVisitaPyP(VisitaPyP visita)
        {
            var visitaAdicionado = _appContext.VisitasPyP.Add(visita);
            _appContext.SaveChanges();
            return visitaAdicionado.Entity;
        }

        public void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitaEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
            if (visitaEncontrado == null)
                return;
            _appContext.VisitasPyP.Remove(visitaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<VisitaPyP> GetAllVisitasPyP()
        {
            //Permite cargar todos los dueños que estan en la base de datos, y la añade a GetAllVisitasPyP
            //de tipo IEnumerable<VisitaPyP>
            return GetAllVisitasPyP_();
        }

        /*public IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(string filtro)
        {
            var visitas = GetAllVisitasPyP(); // Obtiene todos los saludos
            if (visitas != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    visitas = visitas.Where(s => s.Nombres.Contains(filtro));
                }
            }
            return visitas;
        }*/

        public IEnumerable<VisitaPyP> GetAllVisitasPyP_()
        {
            return _appContext.VisitasPyP;
        }

        public VisitaPyP GetVisitaPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
        }

        public VisitaPyP UpdateVisitaPyP(VisitaPyP visita)
        {
            var visitaEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == visita.Id);
            if (visitaEncontrado != null)
            {
                visitaEncontrado.FechaVisita = visita.FechaVisita;
                visitaEncontrado.Temperatura = visita.Temperatura;
                visitaEncontrado.Peso = visita.Peso;
                visitaEncontrado.FrecuenciaRespiratoria = visita.FrecuenciaRespiratoria;
                visitaEncontrado.FrecuenciaCardiaca = visita.FrecuenciaCardiaca;
                visitaEncontrado.EstadoAnimo = visita.EstadoAnimo;
                visitaEncontrado.Recomendaciones = visita.Recomendaciones;
                _appContext.SaveChanges();
            }
            return visitaEncontrado;
        }     
    }
}