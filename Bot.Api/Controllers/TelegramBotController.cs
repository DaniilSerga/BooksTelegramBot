using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace Bot.Api.Controllers
{
    [ApiController]
    [Route("api/message")]
    public class TelegramBotController : Controller
    {
        [HttpPost("update")]
        public IActionResult Update(Update update)
        {
            return Ok();
        }
    }
}
