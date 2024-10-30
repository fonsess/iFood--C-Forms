using api.Data;
using api.Models;
using api.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace api.Controller
{
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [Authorize(Roles ="cliente")]
        [HttpPost]
        [Route(template:"adiciona/pedido")]
        public async Task<IActionResult> PostPedidoAsync(
            [FromServices] AppDbContext context,
            [FromBody] PedidoCreateViewModel model)
        {
            try
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                var userId = context.Usuarios.FirstOrDefault(x => x.Email == userName).Id;
                var user = context.Usuarios.FirstOrDefault(x => x.Id == userId);

                if (user == null) return BadRequest(new { message = "User não existe" });
                var pedido = new Pedido
                {
                    Lanche = model.Lanche,
                    Quantidade = model.Quantidade,
                    Value = model.Value,
                    Horario = DateTime.Now,
                    User = user
                };
                await context.Pedidos.AddAsync(pedido);
                await context.SaveChangesAsync();
                return Created($"{pedido.Id}",pedido);
            }
            catch 
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
       
    }
}
