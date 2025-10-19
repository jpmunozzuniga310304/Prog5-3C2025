using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Prog5_3C2025.Models
{
    public class Enfermedades
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string Enfermedad {  get; set; }

        public DateTime Creada { get; set; } = DateTime.Now;
    }
}
