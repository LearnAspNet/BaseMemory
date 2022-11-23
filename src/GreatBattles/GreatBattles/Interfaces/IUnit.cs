﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatBattles.Interfaces
{
    public interface IUnit
    {
        /// <summary>
        /// Идентификатор юнита
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Показатель жизнеспособности
        /// </summary>
        public int Life { get; set; }

        /// <summary>
        /// Показатель силы
        /// </summary>
        public int Force { get; set; }
    }
}
