using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Alquiler.App.Dominio.Entidades
{
    public class Cliente
    {
        
        //atributos de la clase cliente
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required]        
        [Display(Name = "Nro. Identficación")]
        public string identificacion{ get; set; }
        [Required]        
        [Display(Name = "Nombre del Cliente")]
        public string nombre{ get; set; }
        [Required]        
        [Display(Name = "Correo Electrónico")]
        public string correo{ get; set; }    
        [Display(Name = "Numero de Celular")]
        public string celular{ get; set; }
        [Required]        
        [Display(Name = "Tipo de licencia")]
        public string tipoLicencia{ get; set; }
               
        [Display(Name = "Numero de licencia")]
        public string licencia{ get; set; }
        
    }
}

