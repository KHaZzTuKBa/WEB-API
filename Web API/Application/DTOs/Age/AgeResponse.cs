namespace Application.DTOs.Age
{
    //класс определяет какие поля мы передаем в ответе на "ВОЗРАСТ"
    public record AgeResponse(int Code, string Message);
}
