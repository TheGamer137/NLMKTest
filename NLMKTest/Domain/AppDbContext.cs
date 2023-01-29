using Microsoft.EntityFrameworkCore;
using NLMKTest.Models;

namespace NLMKTest.Domain;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<EquipmentDowntime> EquipmentDowntimes { get; set; }
}