using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using ModelLibrary;

namespace CatView
{
    public class CatV
    {
        public CatM Cat { get; set; }
        public CatV(string age)
        {
            Cat = new CatM(age);
        }
        /// <summary>
        /// Изменяем цвет
        /// </summary>
        /// <param name="NewHeathyColor">новый здоровый цвет</param>
        /// <param name="NewSickColor">новый больной цвет</param>
        public void ChangeColor(string NewHeathyColor, string NewSickColor)
        {
            if (!string.IsNullOrEmpty(NewHeathyColor))
                Cat.Color.HeathyColor = NewHeathyColor;

            if (!string.IsNullOrEmpty(NewSickColor))
                Cat.Color.SickColor = NewSickColor;

        }



    }
}
