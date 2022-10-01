using Alquiler.App.Dominio.Entidades;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace Alquiler.App.Persistencia.AppRepositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContext _appContext;
        public IEnumerable<Cliente> clientes {get; set;}
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }
         Cliente IRepositorioCliente.AddCliente(Cliente cliente)
         {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
         }  

         void IRepositorioCliente.DeleteCliente(int idCliente)
         {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.id == idCliente);
            if(clienteEncontrado == null) 
            return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
         }

         IEnumerable<Cliente> IRepositorioCliente.GetAllClientes(string? searchString)
         {
            if(searchString == null)
            clientes = _appContext.Clientes;
            return  _appContext.Clientes;
         }

         Cliente IRepositorioCliente.GetCliente(int idCliente)
         {
            return _appContext.Clientes.FirstOrDefault(p => p.id == idCliente);
         }

         Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
         {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.id == cliente.id);
            if(clienteEncontrado!=null)
            {
                clienteEncontrado.nombre = cliente.nombre;
                clienteEncontrado.correo = cliente.correo;
                clienteEncontrado.celular = cliente.celular;
                clienteEncontrado.tipoLicencia = cliente.tipoLicencia;
                clienteEncontrado.licencia = cliente.licencia;
                _appContext.SaveChanges();
                
            }
            return clienteEncontrado;
         }
    }
}