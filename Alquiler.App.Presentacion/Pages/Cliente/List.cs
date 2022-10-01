﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Alquiler.App.Dominio; 

namespace Alquiler.App.Presentacion.Pages
{
    public class ListClientesModel : PageModel
    {
        public IEnumerable<ListClientesModel> clientes;
        public ListClientesModel()
        {
            
        }


        public IEnumerable<ListClientesModel> GetClientes()
        {
            return clientes;
        }

        public void SetClientes(IEnumerable<Cliente> value)
        {
            clientes = value;
        }

      
      public void llenar_lista_de_clientes(){
            SetClientes(new IEnumerable<Cliente>(){
            new Cliente{identificacion="1012546786",nombre="Luis Forero",correo="lforero@email.com",
            tipolicencia="C2",celular="3208975431"}, 
            new Cliente{identificacion="1013564362",nombre="Juan Lozano",correo="Juanlozano@email.com",
            tipolicencia="C1",celular="3507864565"},
            new Cliente{identificacion="79581504",nombre="Alexander Medina",correo="amedina@email.com",
            tipolicencia="C1",celular="3156734576"},

        });
      } 

    }
}