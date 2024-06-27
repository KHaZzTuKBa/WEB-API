﻿using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Statistics
{
    //класс определяет какие поля мы получаем в запросе на "СТАТИСТИКУ ИГР"
    public class StatisticsDTO
    {
        [Required]
        public string UserName { get; set; } = default!;
    }
}
