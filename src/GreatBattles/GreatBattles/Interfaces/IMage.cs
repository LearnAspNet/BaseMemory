namespace GreatBattles.Interfaces
{
    public interface IMage
    {
        /// <summary>
        /// Жрец
        /// </summary>
        public int Priest { get; set; }

        /// <summary>
        /// Оракул
        /// </summary>
        public int Oracle { get; set; }

        /// <summary>
        /// Некромант
        /// </summary>
        public int Necromancer { get; set; }

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
