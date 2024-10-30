namespace api.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Lanche { get; set; }
        public int Quantidade { get; set; }
        public decimal Value { get; set; }
        public DateTime Horario { get; set; }
        public User User { get; set; }
    }
}
