using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatColorModel
{
    public class CatColorM
    {
        /// <summary>
        /// Здоровый цвет кошки
        /// </summary>
       public string HeathyColor { get; set; }
        /// <summary>
        /// Не здоровый цвет кошки
        /// </summary>
        public string SickColor { get; set; }

        public CatColorM()
        {
            HeathyColor = "Белый";
            SickColor = "Зеленый";
        }

    }
}
