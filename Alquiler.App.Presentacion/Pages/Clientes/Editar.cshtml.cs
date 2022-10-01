using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquiler.App.Dominio.Entidades;
using Alquiler.App.Persistencia.AppRepositorios;
using Alquiler.App.Persistencia;

namespace Alquiler.App.Presentacion.Clientes
{
    public class EditarModel : PageModel
    {
       private readonly IRepositorioCliente _appContext;

        [BindProperty]
        public Cliente cliente  { get; set; } 

        public EditarModel()
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

        //se ejecuta al presionar Editar en el formulario
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(cliente.id > 0)
            {
               cliente = _appContext.UpdateCliente(cliente); 
            }
            return Redirect("List");
        }
    }
}
