using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquiler.App.Dominio.Entidades;
using Alquiler.App.Persistencia.AppRepositorios;
using Alquiler.App.Persistencia;

namespace Alquiler.App.Presentacion.Clientes
{
    public class DeleteModel : PageModel
    {
       private readonly IRepositorioCliente _appContext;

        [BindProperty]
        public Cliente cliente  { get; set; } 

        public DeleteModel()
        {            
            this._appContext = new RepositorioCliente(new Alquiler.App.Persistencia.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
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

        //se ejecuta al presionar Eliminar en el formulario
        public IActionResult OnPost()
        {
            if(cliente.id > 0)
            {     
               _appContext.DeleteCliente(cliente.id);           
            }
            return Redirect("List");
        }
    }
}