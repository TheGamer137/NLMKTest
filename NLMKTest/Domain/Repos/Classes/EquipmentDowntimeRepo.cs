using NLMKTest.Models;
using NLMKTest.Domain.Repos.Interfaces;

namespace NLMKTest.Domain.Repos.Classes;

public class EquipmentDowntimeRepo:IEquipmentDowntimeRepo
{
    private readonly AppDbContext _context;

    public EquipmentDowntimeRepo(AppDbContext context)
    {
        _context = context;
    }

    public IList<EquipmentDowntime> GetAllEquipmentDowntimes() => _context.EquipmentDowntimes.ToList();

    public void SaveEquipmentDowntime(EquipmentDowntime entity)
    {
        _context.EquipmentDowntimes.Add(entity);
        _context.SaveChanges();
    }

    public EquipmentDowntime GetEquipmentById(int id)=>_context.EquipmentDowntimes.FirstOrDefault(e=>e.Id==id);

    public void DeleteEquipment(int id)
    {
        _context.EquipmentDowntimes.Remove(GetEquipmentById(id));
        _context.SaveChanges();
    }
}