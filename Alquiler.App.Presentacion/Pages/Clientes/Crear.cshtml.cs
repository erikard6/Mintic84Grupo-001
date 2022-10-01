using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquiler.App.Dominio.Entidades;
using Alquiler.App.Persistencia;
using Alquiler.App.Persistencia.AppRepositorios;
namespace Alquiler.App.Presentacion.Clientes
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioCliente _appContext;
        [BindProperty]
        public Cliente cliente { get; set; }

        public CrearModel(){
            //cargar desde la base de datos tabla cliente
            this._appContext = new RepositorioCliente(new Alquiler.App.Persistencia.AppContext());
            //cargarTemporales();
        }
       

        public IActionResult OnGet(int? clienteId)
        {
            if (clienteId.HasValue)
            {
                cliente = _appContext.GetCliente(clienteId.Value);
            }
            else
            {
                cliente = new Cliente();
            }
            if (cliente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

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
            else
            {
                //cliente.vigente = true;
               _appContext.AddCliente(cliente);
            }
            return Redirect("List");
            
        }
    }
}

