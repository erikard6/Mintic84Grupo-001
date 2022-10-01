using System;
using System.ComponentModel.DataAnnotations;

namespace Alquiler.App.Dominio{
    public class Conductor{
        public int id {get;set;} 
        [Required,  StringLength(10,  MinimumLength = 5, ErrorMessage = "El campo debe tener minimo 5 y maximo 10 caracteres")]
        public string con_nombre {get;set;}            
        public string con_celular {get;set;}            
        public string con_tipo_licencia {get;set;}            
               
           
    } 
}