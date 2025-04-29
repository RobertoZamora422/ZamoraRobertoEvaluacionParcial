using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZamoraRobertoEvaluacionParcial.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [DataType(DataType.Currency)]
        public decimal ValorPagar { get; set; }

        // Clave foránea
        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}