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
    public class DeliveryController : ControllerBase
    {
        [Authorize(Roles = "cliente")]
        [HttpPost]
        [Route(template: "adiciona/cep")]
        public async Task<IActionResult> PostCEPAsync(
            [FromServices] AppDbContext context,
            [FromBody] DeliveryCreateViewModel model)
        {
            try
            {
                var userName = User.FindFirst(ClaimTypes.Name).Value;
                var userId = context.Usuarios.FirstOrDefault(x => x.Email == userName).Id;
                var user = context.Usuarios.FirstOrDefault(x => x.Id == userId);


                if (user == null) return BadRequest(new { message = "User não existe" });
                var delivery = new Delivery
                {
                    CEP = model.CEP,
                    Bairro = model.Bairro,
                    Cidade = model.Cidade,
                    Complemento = model.Complemento,
                    Endereco = model.Endereco,
                    Estado = model.Estado,
                    Numero = model.Numero,
                    User = user
                };
                await context.Delivery.AddAsync(delivery);
                await context.SaveChangesAsync();
                return Created($"{delivery.Id}", delivery);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [HttpGet]
        [Route(template:"cep/{CEP}")]
        public async Task<IActionResult> GetCEPAsync(
            [FromServices] AppDbContext context,
            [FromRoute] string CEP)
        {
            try
            {
                var cep = await context.Delivery.FirstOrDefaultAsync(X => X.CEP == CEP);
                if (cep == null) return BadRequest(new {error = "não achei!"});

                return Ok(cep);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }

    }
}
