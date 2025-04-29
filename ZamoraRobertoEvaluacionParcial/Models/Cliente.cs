using System.ComponentModel.DataAnnotations;

namespace ZamoraRobertoEvaluacionParcial.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        [StringLength(15)]
        public string IdCliente { get; set; }


        [Required]
        [StringLength(50)]
        public string NombreCliente { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Range(0,10000)]
        public int puntos { get; set; }

        [Required]
        public string TipoRecompensa { get; set; }

        public bool EsActivo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }


    }
}
