using Application.DTOs.Age;

namespace Application.Contract
{
    //шаблон класса, здесь определяются какие методы будет реализовать данный класс, какие запросы обрабатывать
    public interface IAge
    {
        Task<AgeResponse> SetAge(AgeDTO ageDTO);
    }
}
