using System;
using System.ComponentModel.DataAnnotations;

namespace Alquiler.App.Dominio{
    public class reserva{
        public int id {get;set;} 
        [Required,  StringLength(10,  MinimumLength = 5, ErrorMessage = "El campo debe tener minimo 5 y maximo 10 caracteres")]
        public string res_fecha_reserva {get;set;}            
        public string res_fecha_inicio {get;set;}            
        public string res_fecha_fin {get;set;}            
        public string res_ciudad_destino {get;set;}            
        public string res_peso {get;set;}   
        public string res_contenido_paquete {get;set;}           
           
    } 
}