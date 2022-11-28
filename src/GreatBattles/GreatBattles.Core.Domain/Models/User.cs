using GreatBattles.Core.App.Interfaces;

namespace GreatBattles.Core.Domain.Models;

public class User : IUnit, IHuman, IMage
{
    public User(int id)
    {
        Id = id;
    }

    public User(int id, int life, int force, string name, int kindness, int honestly, int loyalty, int humor, int priest, int oracle, int necromancer, ISkill skill)
    {
        Id = id;
        Life = life;
        Force = force;
        Name = name;
        Kindness = kindness;
        Honesty = honestly;
        Loyalty = loyalty;
        Humor = humor;
        Priest = priest;
        Oracle = oracle;
        Necromancer = necromancer;
        Skill = skill;
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
