using Application.Contract;
using Application.DTOs.Info;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class InfoController : Controller
    {
        private readonly IInfo info;

        public InfoController(IInfo info)
        {
            this.info = info;
        }

        //запрос на получение персональной информации о пользователе
        [HttpGet("getInfo")]
        public async Task<ActionResult<InfoResponse>> GetInfo([FromQuery]InfoDTO infoDTO)
        {
            var result = await info.GetInfo(infoDTO);
            return Ok(result);
        }
    }
}
