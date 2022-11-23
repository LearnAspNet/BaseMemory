namespace GreatBattles.Interfaces
{
    public interface IOrc
    {
        /// <summary>
        /// Имя орка
        /// </summary>
        public string Name { get; set; }

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
    }
}
