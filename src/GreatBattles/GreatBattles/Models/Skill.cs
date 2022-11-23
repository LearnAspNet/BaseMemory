using GreatBattles.Interfaces;

namespace GreatBattles.Models;

public class Skill : ISkill
{
    /// <summary>
    /// Алхимия
    /// </summary>
    public int Alchemy { get; set; }

    /// <summary>
    /// Колдовство
    /// </summary>
    public int Witchcraft { get; set; }

    /// <summary>
    /// Разрушение
    /// </summary>
    public int Destruction { get; set; }

    /// <summary>
    /// Восстановление
    /// </summary>
    public int Recovery { get; set; }

    /// <summary>
    /// Стрельба(Скиллы)
    /// </summary>
    public int Shooting { get; set; }

    /// <summary>
    /// Скрытность(Скиллы)
    /// </summary>
    public int Stealth { get; set; }

    /// <summary>
    /// Взлом(скиллы)
    /// </summary>
    public int Breaking { get; set; }

    /// <summary>
    /// Красноречие(скиллы)
    /// </summary>
    public int Eloquence { get; set; }
}
