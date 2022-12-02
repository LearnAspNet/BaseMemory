namespace GreatBattles.Core.Domain.Models
{
    public class PvpBattle : Battle
    {
        public PvpBattle()
        {
            var random = new Random();

            NumbersOfPlayers = random.Next(0, 10);
        }
    }
}
