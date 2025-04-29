using System.ComponentModel.DataAnnotations;

namespace ZamoraRobertoEvaluacionParcial.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CordovaS { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Range(0, 10000)]
        public int Puntos { get; set; }

        public bool Activo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        public string TipoRecompensa => Puntos >= 500 ? "GOLD" : "SILVER";

        public ICollection<Reserva> Reservas { get; set; }
    }
}