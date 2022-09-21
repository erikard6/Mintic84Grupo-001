using System;
using System.ComponentModel.DataAnnotations;

namespace Alquiler.App.Dominio{
    public class proveedor{
        public int id {get;set;} 
        [Required,  StringLength(10,  MinimumLength = 5, ErrorMessage = "El campo debe tener minimo 5 y maximo 10 caracteres")]
        public string pro_nombre {get;set;}            
        public string pro_celular {get;set;}            
        public string pro_correo {get;set;}            
               
           
    } 
}