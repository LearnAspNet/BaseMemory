using GreatBattles.Core.Domain.Models.Interfaces;

namespace GreatBattles.Core.Domain.Models
{
    public class Battle : IBattle
    {
        /// <summary>
        /// Id битвы
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Счет
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Количество игроков
        /// </summary>
        public int NumbersOfPlayers { get; set; }

        /// <summary>
        /// Победитель
        /// </summary>
        public string Winner { get; set; }
    }
}
