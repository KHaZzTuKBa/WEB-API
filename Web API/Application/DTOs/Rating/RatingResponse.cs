namespace Application.DTOs.Rating
{
    //класс определяет какие поля мы передаем в ответе на "РЕЙТИНГ"
    public record RatingResponse(int Code, string Message, string Rating);
}
