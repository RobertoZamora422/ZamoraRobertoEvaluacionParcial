using System.ComponentModel.DataAnnotations;

namespace ZamoraRobertoEvaluacionParcial.Models
{
    public class PlanRecompensa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Range(0, 10000)]
        public int PuntosAcumulados { get; set; }

        public string TipoRecompensa => PuntosAcumulados >= 500 ? "GOLD" : "SILVER";
    }
}