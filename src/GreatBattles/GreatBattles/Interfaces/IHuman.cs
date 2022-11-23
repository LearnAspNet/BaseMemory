namespace GreatBattles.Interfaces
{
    public interface IHuman
    {
        /// <summary>
        /// Имя человека
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
    }
}
