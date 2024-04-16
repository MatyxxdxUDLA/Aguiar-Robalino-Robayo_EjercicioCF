using System.ComponentModel.DataAnnotations;

namespace Aguiar_Robalino_Robayo_EjercicioCF.Models
{
    public class Estudiante
    {
        [Key]
        public required int IdBanner { get; set; }
        public String Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Vacuna Vacuna { get; set; }
        public RecintoVacunacion RecintoVacunacion { get; set; }
    }
}
