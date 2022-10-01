using System;
using System.ComponentModel.DataAnnotations;

namespace Alquiler.App.Dominio{
    public class vehiculo_carga{
        public int id {get;set;} 
        [Required,  StringLength(10,  MinimumLength = 5, ErrorMessage = "El campo debe tener minimo 5 y maximo 10 caracteres")]
        public string vehcar_peso_max {get;set;}            
        public string vehcar_peso_min {get;set;}            
      
    } 
}