using System.ComponentModel.DataAnnotations;

namespace api.ViewModel
{
    public class DeliveryCreateViewModel
    {
        [Required]
        public string CEP { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public int Numero { get; set; }
    }
    public class DeliveryGetViewModel
    {
        [Required]
        public string CEP { get; set; }
    }
}
