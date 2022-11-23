namespace GreatBattles.Interfaces
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
        public ISkill Skill { get; set; }

        /// <summary>
        /// Обновление скиллов
        /// </summary>
        /// <param name="skill"></param>
        public void UpdateSkills(ISkill skill);
    }
}
