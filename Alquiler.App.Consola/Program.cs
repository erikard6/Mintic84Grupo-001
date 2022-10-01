// See https://aka.ms/new-console-template for more information
using System;
using Alquiler.App.Dominio.Entidades;
using Alquiler.App.Persistencia;
using System.Collections.Generic;

namespace Alquiler.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //AddCliente();
            //BuscarCliente(1);
        }

        private static void AddCliente()
        {
            var cliente = new Cliente
            {
                identificacion = "578964",
                nombre = "jose eduarte",
                correo = "josedu@gmail.com",
                celular = "4567898765",
                tipoLicencia = "C2",
                licencia = "678994944"
            };
            _repoCliente.AddCliente(cliente);
        }

        private static void BuscarCliente(int idCliente)
        {
            var cliente = _repoCliente.GetCliente(idCliente);
            Console.WriteLine(cliente.nombre+" "+ cliente.identificacion);
        }
    }
}

