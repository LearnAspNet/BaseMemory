using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App.Interfaces
{
    public interface IBattleService
    {
        public PveBattle Battle(User user, Mob mob);

        public PvpBattle PvpBattle(User user);
    }
}
