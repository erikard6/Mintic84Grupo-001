using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Alquiler.App.Dominio.Entidades;
using Alquiler.App.Persistencia;
using Alquiler.App.Persistencia.AppRepositorios;
namespace Alquiler.App.Presentacion.Page.Clientes
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorioCliente _appContext;
        public IEnumerable<Cliente> clientes {get; set;} 
        public string searchString;          

        public ListModel()
        {
            this._appContext = new RepositorioCliente(new Alquiler.App.Persistencia.AppContext());
        }
       
        public void OnGet()
        {
            clientes = _appContext.GetAllClientes(searchString);
        }        

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            clientes = _appContext.GetAllClientes(searchString);
            return Page();
        }
        
    }
}