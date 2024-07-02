using Application.Contract.GameProfile;
using Application.DTOs.GameProfile.Profile.GetProfile;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Profile
{

    [Route("api/[controller]")]
    [ApiController]

    public class ProfileController : Controller
    {

        private readonly IProfile profile;

        public ProfileController(IProfile profile)
        {
            this.profile = profile;
        }

        //запрос на получение игрового профиля пользователя
        [HttpGet("getProfile")]
        public async Task<ActionResult<ProfileResponse>> GetProfileInfo([FromQuery] ProfileDTO profileDTO)
        {
            var result = await profile.GetProfile(profileDTO);
            return Ok(result);
        }
    }
}
