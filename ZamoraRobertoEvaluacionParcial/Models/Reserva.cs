using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZamoraRobertoEvaluacionParcial.Models
{
    public class Reserva
    {
        [Key]
        public int idReserva { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaEntrada { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaSalida { get; set; }

        public decimal valorPagar { get; set; }

        [ForeignKey("IdCliente")]
        [Required]
        public int idCliente { get; set; }

        public Cliente Cliente { get; set; }
    }
}
