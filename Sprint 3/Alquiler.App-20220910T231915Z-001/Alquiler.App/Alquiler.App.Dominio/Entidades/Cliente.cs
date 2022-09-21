using System;
using System.ComponentModel.DataAnnotations;

namespace Alquiler.App.Dominio{
    public class Cliente{
        public int id {get;set;} 
        [Required,  StringLength(10,  MinimumLength = 5, ErrorMessage = "El campo debe tener minimo 5 y maximo 10 caracteres")]
        public string identificacion {get;set;}            
        public string nombre {get;set;}            
        public string correo {get;set;}            
        public string celular {get;set;}            
        public string licencia {get;set;}   
        public string tipolicencia {get;set;}           
           
    } 
}