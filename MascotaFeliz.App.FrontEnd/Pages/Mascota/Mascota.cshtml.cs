using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.FrontEnd.Pages
{
    public class MascotaModel : PageModel
    {
        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        [BindProperty]
        public Mascota mascota {get;set;}
        public Dueno dueno {get;set;}
        public IEnumerable<Dueno> listaDuenos {get;set;}

        public MascotaModel()
        {
            this._repoMascota=new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno= new RepositorioDueno(new Persistencia.AppContext());
        }

          public void OnGet(int? mascotaId)
	    {
            listaDuenos=_repoDueno.GetAllDuenos();

            if (mascotaId.HasValue)
            {
                mascota=_repoMascota.GetMascota(mascotaId.Value);
            }

            if(mascota==null){
                RedirectToPage("./NotFound");
            }
            else{
             Page();   
            }           
         }


         public IActionResult OnPost(Mascota mascota, int duenoId )
         {
            if (!ModelState.IsValid)
            {   
                dueno=_repoDueno.GetDueno(duenoId);
                if(mascota.Id>0)
                {
                    mascota.Dueno=dueno;
                    mascota=_repoMascota.UpdateMascota(mascota);
                }
                /*
                else
                {
                _repoMascota.AddMascota(mascota);
                }*/
                return  RedirectToPage("/Mascota/ListarMascota");
            }
            else
            {
                return Page();
            }
        }

    }
}

