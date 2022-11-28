using GreatBattles.Core.App.Interfaces;
using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.Domain
{
    public class Statistic : IHuman, IOrc, IMage, IWarrior
    {
        public string Name { get; set; }

        public int Kindness { get; set; }

        public int Honesty { get; set; }

        public int Loyalty { get; set; }    

        public int Humor { get; set; }  

        public int Ferocity { get; set; }

        public int Age { get; set; }

        public int Leadership { get; set; }

        public int Malice { get; set; }

        public int Priest { get; set; }

        public int Oracle { get; set; }

        public int Necromancer { get; set; }

        public ISkill Skill { get; set; }

        public void UpdateSkills(ISkill skill)
        {
            Skill = skill;
        }

        public int Archer { get; set; }

        public int Thief { get; set; }

        public int Spearman { get; set; }

        public List<User> Users { get; set; }

        public List<Battle> Battles { get; set; }
    }
}
