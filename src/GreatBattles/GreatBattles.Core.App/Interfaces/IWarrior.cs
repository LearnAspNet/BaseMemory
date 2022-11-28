using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App.Interfaces
{
    public interface IWarrior
    {
        /// <summary>
        /// Лучник
        /// </summary>
        public int Archer { get; set; }

        /// <summary>
        /// Копьеносец
        /// </summary>
        public int Spearman { get; set; }

        /// <summary>
        /// Вор
        /// </summary>
        public int Thief { get; set; }

        /// <summary>
        /// Навыки
        /// </summary>
        public Skill Skill { get; set; }

        /// <summary>
        /// Обновление скиллов
        /// </summary>
        /// <param name="skill"></param>
        public void UpdateSkills(Skill skill);
    }
}
