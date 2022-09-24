using System;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Alquiler.App.Dominio; 

namespace Alquiler.App.Presentacion.Pages
{
    public class ListVehiculoModel:PageModel
    {
        public IEnumerable <Vehiculo>vehiculos{get;set;}       
      public ListVehiculoModel()
      {
        
      } 
      public void llenar_lista_de_vehiculos(){
        vehiculos = new IEnumerable<Vehiculo>(){
            new Vehiculo{veh_placa="MSM482",veh_modelo="2012",veh_precio="200"}, 
            new Vehiculo{veh_placa="HSF234",veh_modelo="2020",veh_precio="400"},
            new Vehiculo{veh_placa="TYH876",veh_modelo="2012",veh_precio="100"},

        };
      } 

    }
}