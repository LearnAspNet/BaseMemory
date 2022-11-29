namespace GreatBattles.Core.App.Interfaces
{
    public interface IBattle
    {
        /// <summary>
        /// Id битвы
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Счет
        /// </summary>
        public int Score { get; set; }
    }
}
