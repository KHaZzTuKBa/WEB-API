using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Guild.IsAdmin
{
    //класс определяет какие поля мы получаем в запросе на "ПРОВЕРКУ НА АДМИНИСТРАТОРА ГИЛЬДИИ"
    public class IsAdminOfGuildDTO
    {
        [Required]
        public string GuildName { get; set; } = default!;

        [Required]
        public string UserName { get; set;} = default!;
    }
}
