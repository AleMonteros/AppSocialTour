using System;
using System.ComponentModel.DataAnnotations;

namespace AppSocialTour.Models
{
    public class Social
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required]
        public string Horario { get; set; }

        [MaxLength(15)]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string SitioWeb { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Historia { get; set; }







    }
}