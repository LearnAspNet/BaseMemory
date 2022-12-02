namespace GreatBattles.Core.Domain.Models
{
    public class PveBattle : Battle
    {
        public PveBattle()
        {
            var random = new Random();

            NumbersOfMobs = random.Next(0, 10);
            NumbersOfPlayers = random.Next(0, 10);
        }

        //public PveBattle(int numbersOfMobs, int id, int score, int numberOfPlayers, string winner)
        //{
        //    NumbersOfMobs = numbersOfMobs;
        //    Id = id;
        //    Score = score;
        //    NumbersOfPlayers = numberOfPlayers;
        //    Winner = winner;
        //}

        /// <summary>
        /// Количество мобов
        /// </summary>
        public int NumbersOfMobs { get; set; }
    }
}
