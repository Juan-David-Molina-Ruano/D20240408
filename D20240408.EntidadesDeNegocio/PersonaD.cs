using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D20240408.EntidadesDeNegocio
{
    public class PersonaD
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string NombreD { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ApellidoD { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime FechaNacimientoD { get; set; }

        [Display(Name = "Sueldo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public decimal SueldoD { get; set; }

        [Display(Name = "Estatus")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public byte EstatusD { get; set; }

        [Display(Name = "Comentario")]
        public string? ComentarioD { get; set; } 
    }
}
