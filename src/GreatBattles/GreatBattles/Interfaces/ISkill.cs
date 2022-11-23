namespace GreatBattles.Interfaces
{
    public interface ISkill
    {
        /// <summary>
        /// Стрельба
        /// </summary>
        public int Shooting { get; set; }

        /// <summary>
        /// Скрытность
        /// </summary>
        public int Stealth { get; set; }

        /// <summary>
        /// Взлом
        /// </summary>
        public int Breaking { get; set; }
        
        /// <summary>
        /// Красноречие
        /// </summary>
        public int Eloquence { get; set; }
    }
}
