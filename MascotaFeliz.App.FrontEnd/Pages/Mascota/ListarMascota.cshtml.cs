using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.FrontEnd
{
    public class ListarMascotaModel : PageModel
    {

        private readonly IRepositorioMascota _repoMascota;

        public IEnumerable<Mascota> listaMascotas {get;set;}

        public ListarMascotaModel()
        {
            this._repoMascota= new RepositorioMascota(new Persistencia.AppContext());
        }

        public void OnGet()
        {
            listaMascotas=_repoMascota.GetAllMascotas();
        }
    }
}
