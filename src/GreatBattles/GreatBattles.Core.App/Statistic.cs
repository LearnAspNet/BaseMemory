using GreatBattles.Core.Domain.Models.Interfaces;
using GreatBattles.Core.App.Interfaces;
using GreatBattles.Core.Domain.Models;

namespace GreatBattles.Core.App
{
    public class Statistic : IHuman, IOrc, IMage, IWarrior
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Доброта
        /// </summary>
        public int Kindness { get; set; }

        /// <summary>
        /// Честность
        /// </summary>
        public int Honesty { get; set; }

        /// <summary>
        /// Верность
        /// </summary>
        public int Loyalty { get; set; }    

        /// <summary>
        /// Юмор
        /// </summary>
        public int Humor { get; set; }  

        /// <summary>
        /// Свирепость
        /// </summary>
        public int Ferocity { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Лидерство
        /// </summary>
        public int Leadership { get; set; }

        /// <summary>
        /// Злоба
        /// </summary>
        public int Malice { get; set; }

        /// <summary>
        /// Жрец
        /// </summary>
        public int Priest { get; set; }

        /// <summary>
        /// Оракул
        /// </summary>
        public int Oracle { get; set; }

        /// <summary>
        /// Некромант
        /// </summary>
        public int Necromancer { get; set; }

        /// <summary>
        /// Скиллы
        /// </summary>
        public ISkill Skill { get; set; }

        /// <summary>
        /// Обновление скиллов
        /// </summary>
        /// <param name="skill"></param>
        public void UpdateSkills(ISkill skill)
        {
            Skill = skill;
        }

        /// <summary>
        /// Лучник
        /// </summary>
        public int Archer { get; set; }

        /// <summary>
        /// Вор
        /// </summary>
        public int Thief { get; set; }

        /// <summary>
        /// Копьеносец
        /// </summary>
        public int Spearman { get; set; }

        /// <summary>
        /// Игроки
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Сражения
        /// </summary>
        public List<Battle> Battles { get; set; }
    }
}
