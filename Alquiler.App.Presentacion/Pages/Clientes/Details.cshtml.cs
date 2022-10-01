using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquiler.App.Dominio.Entidades;
using Alquiler.App.Persistencia;
using Alquiler.App.Persistencia.AppRepositorios;

namespace Alquiler.App.Presentacion.Clientes
{
    public class DetailsModel : PageModel
    {
       private readonly IRepositorioCliente _appContext;

        [BindProperty]
        public Cliente cliente  { get; set; } 

        public DetailsModel()
        {            
            this._appContext = new RepositorioCliente(new Alquiler.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? clienteId)
        {
            if (clienteId.HasValue)
            {
                cliente = _appContext.GetCliente(clienteId.Value);
            }
            if (cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }
    }
}