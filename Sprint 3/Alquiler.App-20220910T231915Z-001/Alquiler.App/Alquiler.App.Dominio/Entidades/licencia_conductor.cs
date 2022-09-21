using System;
using System.ComponentModel.DataAnnotations;

namespace Alquiler.App.Dominio{
    public class licencia_conductor{
        public int id {get;set;} 
        [Required,  StringLength(10,  MinimumLength = 5, ErrorMessage = "El campo debe tener minimo 5 y maximo 10 caracteres")]
        public string lincon_nombre {get;set;}            
                  
               
           
    } 
}