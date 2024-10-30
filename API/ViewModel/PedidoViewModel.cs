using api.Models;
using System.ComponentModel.DataAnnotations;

namespace api.ViewModel
{
    public class PedidoCreateViewModel
    {
        [Required]
        public string Lanche { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public decimal Value { get; set; }
    }

}
