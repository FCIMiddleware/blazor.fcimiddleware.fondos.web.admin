using System.ComponentModel.DataAnnotations;

namespace blazor.fcimiddleware.fondos.web.admin.Models.V1.Monedas
{
    public class CreateMonedaRequest
    {
        [Required(ErrorMessage = "La {0} es obligatorio")]
        [StringLength(250, ErrorMessage = "El {0} debe estar entre al menos {2} caracteres de longitud", MinimumLength = 5)]
        public string Descripcion { get; set; }
        public string IdCAFCI { get; set; }
        public bool IsSincronized { get; set; } = false;
    }
}
