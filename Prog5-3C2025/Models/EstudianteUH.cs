using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class EstudianteUH
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Nombre completo")]
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public EstudianteUH()
        {
        }

        public EstudianteUH(int id, string nombre, int edad)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
        }
    }
}
