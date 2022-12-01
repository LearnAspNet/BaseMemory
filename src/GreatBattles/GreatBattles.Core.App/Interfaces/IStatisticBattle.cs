using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App.Interfaces
{
    public interface IStatisticBattleService
    {
        public Statistic GetStatistic();

        public Statistic GetStatisticBattles();
    }
}
