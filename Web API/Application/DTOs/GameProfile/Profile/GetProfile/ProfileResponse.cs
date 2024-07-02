﻿namespace Application.DTOs.GameProfile.Profile
{
    //класс определяет какие поля мы передаем в ответе на "ПРОФИЛЬ"
    public record ProfileResponse(int Code, string Message, string Email, string Rating, string Wins, string GuildName);

}
