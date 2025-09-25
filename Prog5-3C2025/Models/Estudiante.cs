using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_3C2025.Models
{
    public class Estudiante
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Nombre completo")]
        public string Nombre { get; set; }
        public int Nota { get; set; }

        public Estudiante(int id, string nombre, int nota)
        {
            Id = id;
            Nombre = nombre;
            Nota = nota;
        }
    }
}
