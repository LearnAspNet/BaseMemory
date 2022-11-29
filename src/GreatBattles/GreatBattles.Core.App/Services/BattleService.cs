using GreatBattles.Core.App.Interfaces;
using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App.Services
{
    public class BattleService
    {        
        public void Battle(User user, Mob mob, Skill skill)
        {
            var userLife = user.Life - mob.Force;
            var mobLife = mob.Life - user.Force;

            if (userLife > mobLife)
            {
                skill.Witchcraft += 1;
                skill.Alchemy += 1;
                skill.Stealth += 1;
                skill.Shooting += 1;
                skill.Breaking += 1;
                skill.Destruction += 1;
                skill.Eloquence += 1;
                skill.Recovery += 1;

                Console.WriteLine("Победа! Увеличен уровень скиллов");
            }
            else
            {
                Console.WriteLine("Потрачено. Начните битву заново");
                Environment.Exit(0);
            }
        }
    }
}
