using System.ComponentModel.DataAnnotations;
using NLMKTest.Services;

namespace NLMKTest.Models;

public class EquipmentDowntime
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Введите название оборудования")]
    [Display(Name = "Оборудование")]
    public string EquipmentName { get; set; }
    
    [Required(ErrorMessage = "Введите начало простоя")]
    [Display(Name = "Начало простоя")]
    [DataType(DataType.DateTime)]
    [DateGreaterThan("DownTimeEnd")]
    public DateTime DowntimeStart { get; set; }
    
    [Required(ErrorMessage = "Введите конец простоя")]
    [Display(Name = "Конец простоя")]
    [DataType(DataType.DateTime)]
    public DateTime DownTimeEnd { get; set; }
}