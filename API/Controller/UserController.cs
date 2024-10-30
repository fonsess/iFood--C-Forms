using api.Data;
using api.Models;
using api.Services;
using api.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace api.Controller
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route(template: "login")]
        public async Task<IActionResult> LoginAsync(
       [FromServices] AppDbContext context, [FromBody] UserLoginViewModel model)
        {
            try
            {
                var user = await context.Usuarios.FirstOrDefaultAsync(x => x.Email == model.Email && x.Password == Settings.GenerateHash(model.Password));
                if (user == null) { return NotFound(new { mensagem = "Email ou senha errados!" }); }
                var token = TokenServices.GenerateToken(user);
                return Ok(new
                {
                    user = user,
                    token = token
                });
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [HttpPost]
        [Route(template: "cadastro")]
        public async Task<IActionResult> SignupAsync(
           [FromBody] UserCadastroViewModel model,
           [FromServices] AppDbContext context)
        {
            try
            {

                var user = await context.Usuarios.FirstOrDefaultAsync(x => x.Email == model.Email);

                if (user != null)
                    return StatusCode(401, new { message = "Email já cadastrado!" });

                var newUser = new User
                {
                    Email = model.Email.ToLower(),
                    Password = Settings.GenerateHash(model.Password),
                    Name = model.Name,
                    Genero = model.Genero,
                    Nascimento = model.Nascimento,
                    Role = "cliente"
                };

                await context.Usuarios.AddAsync(newUser);
                await context.SaveChangesAsync();

                return Created($"{newUser.Id}", newUser);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [HttpPut]
        [Route(template: "redefinir/senha")]
        public async Task<IActionResult> PutSenhaAsync(
           [FromBody] UserLoginViewModel model,
           [FromServices] AppDbContext context)
        {
            try
            {
                var user = await context.Usuarios.FirstOrDefaultAsync(x => x.Email == model.Email);

                if (user == null)
                    return StatusCode(401, new { message = "Email não cadastrado!" });

                user.Email = model.Email.ToLower();
                user.Password = Settings.GenerateHash(model.Password);

                context.Usuarios.Update(user);
                await context.SaveChangesAsync();

                return Ok("Cadastro atualizado com sucesso");
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [Authorize(Roles ="admin")]
        [HttpGet]
        [Route(template:"usuarios")]
        public async Task<IActionResult> GetAsync(
            [FromServices] AppDbContext context)
        {
            try
            {
                var tasks = await context.Usuarios.Where(x => x.Role == "cliente").ToListAsync();
                return Ok(tasks);
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
        [Authorize(Roles = "admin")]
        [HttpDelete]
        [Route(template: "remove/user/{id}")]
        public async Task<IActionResult> DeleteUserAsync(
           [FromServices] AppDbContext context,
           [FromRoute] int id)
        {
            try
            {
                var user = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

                if (user == null)
                    return NotFound(new { message = "Usuário não encontrado!" });

                var Delivery = await context.Delivery.Where(x => x.User.Id == id).ToListAsync();
                var Pedidos = await context.Pedidos.Where(x => x.User.Id == id).ToListAsync();

                if (Delivery.Any())
                {
                    context.Delivery.RemoveRange(Delivery);
                    await context.SaveChangesAsync();
                }
                if (Pedidos.Any())
                {
                    context.Pedidos.RemoveRange(Pedidos);
                    await context.SaveChangesAsync();
                }

                context.Usuarios.Remove(user);
                await context.SaveChangesAsync();

                return Ok("Usuário e transações associadas deletadas com sucesso!");
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno do servidor" });
            }
        }

        [Authorize(Roles = "admin")]
        [HttpPut]
        [Route(template: "update/user/{id}")]
        public async Task<IActionResult> UpdateUserAsync(
           [FromServices] AppDbContext context,
           [FromBody] UserUpdateViewModel model,
           [FromRoute] int id)
        {
            try
            {
                var user = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);

                if (user == null)
                    return NotFound(new { message = "Usuário não encontrado!" });

                var validador = await context.Usuarios.FirstOrDefaultAsync(x => x.Email == model.Email);
                if (validador != null && model.Email != user.Email)
                {
                    return StatusCode(401, new { message = "Email já cadastrado!" });
                }
                user.Name = model.Name;
                user.Email = model.Email;
                user.Password = Settings.GenerateHash(model.Password);
                user.Nascimento = model.Nascimento;
                user.Genero = model.Genero;

                context.Usuarios.Update(user);
                await context.SaveChangesAsync();

                return Ok("Usuário atualizado com sucesso!");
            }
            catch
            {
                return StatusCode(500, new { message = "Erro interno" });
            }
        }
    }
}
