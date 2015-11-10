using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatColorModel;


namespace CatModel
{
    public class CatM
    {
        /// <summary>
        /// Name value
        /// </summary>
        private string _name;

        /// <summary>
        /// Name - write first Property
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                    _name = value;
            }
        }

        /// <summary>
        /// Readonly property для возраста
        /// </summary>
        private readonly string _age;

        public string Age
        {
            get { return _age; }
        }




        /// <summary>
        /// Конструктор с устновкой возраста при покупке
        /// </summary>
        /// <param name="age">возраст, устанавливаемый при покупке</param>
        public CatM(string age)
        {
            _age = age;
            _health = 5;
            Color = new CatColorM();
        }
        /// <summary>
        /// Readwrite property - ЦВЕТ КОШКИ
        /// </summary>
        public CatColorM Color { get; set; }
        

        /// <summary>
        /// Private field - ЗДОРОВЬЕ КОТАНА
        /// </summary>
        private int _health;
        /// <summary>
        /// Кормление кошки
        /// </summary>
        public void Feed()
        {
            _health++;

        }
        /// <summary>
        /// наказать животное 
        /// </summary>
        public void Punish()
        {
            _health--;
        }
        /// <summary>
        /// вычисляемое поле. 
        /// </summary>
        public string CurrentColor
        {
            get
            {
                var str = string.Empty;
                str = (_health < 5) ? Color.SickColor : Color.HeathyColor;
                return str;
            } 

        }

    }

    
}
