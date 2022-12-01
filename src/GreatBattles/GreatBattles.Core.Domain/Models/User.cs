using GreatBattles.Core.Domain.Models.Interfaces;

namespace GreatBattles.Core.Domain.Models;

public class User : IUnit, IHuman, IMage
{
    //public User(int id)
    //{
    //    var random = new Random();
    //    Id = random.Next(1, 100);
    //}

    public User()
    {
        var random = new Random();
        Id = random.Next(1, 100);
        Life = random.Next(1, 100);
        Force = random.Next(1, 100);
        Name = new Guid().ToString();
        Kindness = random.Next(1, 100);
        Honesty = random.Next(1, 100);
        Loyalty = random.Next(1, 100);
        Humor = random.Next(1, 100);
        Priest = random.Next(1, 100);
        Oracle = random.Next(1, 100);
        Necromancer = random.Next(1, 100);
        Skill = new Skill();
    }

    /// <summary>
    /// Идентификатор юзера
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Показатель жизнеспособности юнита
    /// </summary>
    public int Life { get; set; }

    /// <summary>
    /// Сила юнита
    /// </summary>
    public int Force { get; set; }

    /// <summary>
    /// Имя юнита
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Доброта юнита
    /// </summary>
    public int Kindness { get; set; }

    /// <summary>
    /// Честность юнита
    /// </summary>
    public int Honesty { get; set; }

    /// <summary>
    /// Верность юнита
    /// </summary>
    public int Loyalty { get; set; }

    /// <summary>
    /// Юмор юнита
    /// </summary>
    public int Humor { get; set; }

    /// <summary>
    /// Способности жреца(Юнит)
    /// </summary>
    public int Priest { get; set; }

    /// <summary>
    /// Способности оракула(Юнит)
    /// </summary>
    public int Oracle { get; set; }

    /// <summary>
    /// Способности некроманта(Юнит)
    /// </summary>
    public int Necromancer { get; set; }

    /// <summary>
    /// Навыки юнита
    /// </summary>
    public ISkill Skill { get; set; }

    /// <summary>
    /// Обновление скиллов(Юнит)
    /// </summary>
    /// <param name="skill"></param>
    public void UpdateSkills(ISkill skill)
    {
        Skill = skill;
    }
}
