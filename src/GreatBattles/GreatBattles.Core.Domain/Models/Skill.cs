using GreatBattles.Core.App.Interfaces;

namespace GreatBattles.Core.Domain.Models;

public class Skill : ISkill
{
    public Skill()
    {
        var random = new Random();
        Alchemy = random.Next(1, 100);
        Witchcraft = random.Next(1, 100);
        Destruction = random.Next(1, 100);
        Recovery = random.Next(1, 100);
        Shooting = random.Next(1, 100);
        Stealth = random.Next(1, 100);
        Breaking = random.Next(1, 100);
        Eloquence = random.Next(1, 100);
    }
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
