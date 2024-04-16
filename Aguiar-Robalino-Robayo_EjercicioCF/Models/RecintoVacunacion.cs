namespace Aguiar_Robalino_Robayo_EjercicioCF.Models
{
    public class RecintoVacunacion
    {
        public RecintoVacunacion() {
        }
        public int Id { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public DateTime FechaVacuna { get; set; }
    }
}
