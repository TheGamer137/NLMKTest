using NLMKTest.Models;

namespace NLMKTest.Domain.Repos.Interfaces;

public interface IEquipmentDowntimeRepo
{
    IList<EquipmentDowntime> GetAllEquipmentDowntimes();
    void SaveEquipmentDowntime(EquipmentDowntime entity);
    EquipmentDowntime GetEquipmentById(int id);
    void DeleteEquipment(int id);
}