namespace GreatBattles.Core.Domain.Models
{
    public class Statistic
    {
        /// <summary>
        /// Кол-во раненых
        /// </summary>
        public int Wounded { get; set; }

        /// <summary>
        /// Кол-во убитых
        /// </summary>
        public int Killed { get; set; }

        /// <summary>
        /// Общий урон
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// Игроки
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Сражения
        /// </summary>
        public List<Battle> Battles { get; set; }
    }
}
