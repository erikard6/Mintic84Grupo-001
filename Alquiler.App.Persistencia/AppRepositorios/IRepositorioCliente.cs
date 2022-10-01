using Alquiler.App.Dominio.Entidades;
using System.Collections.Generic;
namespace Alquiler.App.Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllClientes(string? searchString);
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);
        Cliente GetCliente(int idCliente);
    }
}