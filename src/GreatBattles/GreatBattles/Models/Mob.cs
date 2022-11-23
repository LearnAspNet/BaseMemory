using GreatBattles.Interfaces;

namespace GreatBattles.Models;

public class Mob : IUnit
{
    public Mob(int id, int life, int force)
    {
        Id = id;
        Life = life;
        Force = force;
    }

    /// <summary>
    /// Идентификатор моба
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Показатель жизнеспособности моба
    /// </summary>
    public int Life { get; set; }

    /// <summary>
    /// Показатель силы моба
    /// </summary>
    public int Force { get; set; }
}
