using GreatBattles.Core.App.Interfaces;
using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App.Services
{
    public class BattleService : IBattleService
    {
        public PveBattle Battle(User user, Mob mob)
        {
            var userLife = user.Life - mob.Force;
            var mobLife = mob.Life - user.Force;
            var pveBattle = new PveBattle();
            pveBattle.Id = 0;
            pveBattle.Score = 0;
            var usersLife = pveBattle.NumbersOfPlayers * user.Life;
            var mobsLife = pveBattle.NumbersOfMobs * mob.Life;
            var usersForce = pveBattle.NumbersOfPlayers * user.Force;
            var mobsForce = pveBattle.NumbersOfMobs * mob.Force;
            
            

            if (userLife > mobLife)
            {
                pveBattle.Winner = "Users";
            }
            else
            {
                pveBattle.Winner = "Mobs";
            }
            
            return pveBattle;
        }

        public PvpBattle PvpBattle(User user)
        {
            var pvpBattle = new PvpBattle();
            return pvpBattle;
        }

        //public void Battle(User user, Mob mob, Skill skill)
        //{
        //    var userLife = user.Life - mob.Force;
        //    var mobLife = mob.Life - user.Force;

        //    if (userLife > mobLife)
        //    {
        //        skill.Witchcraft += 1;
        //        skill.Alchemy += 1;
        //        skill.Stealth += 1;
        //        skill.Shooting += 1;
        //        skill.Breaking += 1;
        //        skill.Destruction += 1;
        //        skill.Eloquence += 1;
        //        skill.Recovery += 1;

        //        Console.WriteLine("Победа! Увеличен уровень скиллов");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Потрачено. Начните битву заново");
        //    }
        //}
    }
}
