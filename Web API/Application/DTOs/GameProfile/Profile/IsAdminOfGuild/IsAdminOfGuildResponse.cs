namespace Application.DTOs.Guild.IsAdmin
{
    //класс определяет какие поля мы передаем в ответе на "ПРОВЕРКУ НА АДМИНИСТРАТОРА ГИЛЬДИИ"
    public record IsAdminOfGuildResponse(int Code, string Message);
}
