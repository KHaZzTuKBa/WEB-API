﻿namespace Application.DTOs.ChangePassword
{
    //класс определяет какие поля мы передаем в ответе на "СМЕНУ ПАРОЛЯ"
    public record ChangePasswordResponse(int Code, string Message);
}
