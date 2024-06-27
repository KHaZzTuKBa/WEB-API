using Application.Contract;
using Application.DTOs.About;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AboutController : Controller
    {
        private readonly IAbout about;

        public AboutController(IAbout about)
        {
            this.about = about;
        }

        //запрос на запись О СЕБЕ
        [HttpPatch("setAbout")]
        public async Task<ActionResult<AboutResponse>> SetAbout(AboutDTO aboutDTO)
        {
            var result = await about.SetAbout(aboutDTO);
            return Ok(result);
        }
    }
}
