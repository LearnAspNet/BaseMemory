using GreatBattles.Core.App.Interfaces;

namespace GreatBattles.Core.App
{
    public class StatisticBattle : IStatisticBattle
    {
        public Statistic GetStatistic()
        {
            var statistic = new Statistic();

            return statistic;
        }

        public Statistic GetStatisticBattles()
        {
            return new Statistic();
        }
    }
}
