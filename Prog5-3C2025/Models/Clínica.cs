using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class Clínica
    {
        [Key]
        public int IddelaClínica { get; set; }

        [Required]
        public string NombredelaClínica {  get; set; }

        [Required]
        [DisplayName("Provincia")]
        [Range(1, 7, ErrorMessage = "Los valores de las provincias deben estar entre 1 y 7")]

        public int ProvinciaId { get; set; }
        public int CantonId { get; set; }
        public int DistritoId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Clínica()
        {
        }
    }
}
