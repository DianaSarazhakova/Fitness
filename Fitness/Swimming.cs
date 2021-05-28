using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    /// <summary>
    /// Класс для описания плавания
    /// </summary>
    public class Swimming : ExercisesBase
    {
        #region Словари

        /// <summary>
        /// Соответсвие каллорий стилю плавания
        /// Ключ - стиль плавания
        /// </summary>
        private Dictionary<SwimmingStyles, double> _swimmingKkalDictionary =
            new Dictionary<SwimmingStyles, double>()
            {
                {SwimmingStyles.Backstroke, 5.0},
                {SwimmingStyles.Breaststroke, 6.0},
                {SwimmingStyles.Butterfly, 7.0},
                {SwimmingStyles.Crawl, 8.0},
                {SwimmingStyles.Sidestroke, 9.0},
            };

        #endregion

        #region Поля

        /// <summary>
        /// Сжигаемые калории в зависимости от стиля
        /// </summary>
        private double _kkal;

        /// <summary>
        /// Поле стилей плавания
        /// </summary>
        private SwimmingStyles _swimmingStyle;

        #endregion

        #region Cвойства

        /// <summary>
        /// Свойство стиль плавания
        /// </summary>
        public SwimmingStyles SwimmingStyle
        {
            get => _swimmingStyle;

            set
            {
                _swimmingStyle = value;
                _kkal = _swimmingKkalDictionary[_swimmingStyle];
            }
        }

        #endregion

        #region Коструктор

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="distanceOrWeight">Расстояние</param>
        /// <param name="weightOfPerson">Вес человека</param>
        /// <param name="time">Время заплыва</param>
        /// <param name="swimmingEnum">Калории от стиля плавания</param>
        public Swimming(double distanceOrCountOfSets, double weightOfPerson,
                         double time, SwimmingStyles swimmingStyle)
        {
            DistanceOrCountOfSets = distanceOrCountOfSets;
            WeightOfPerson = weightOfPerson;
            Time = time;
            SwimmingStyle = swimmingStyle;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Расчёт калорий
        /// </summary>
        /// <returns>калории</returns>
        public override double CalculationOfKkal
        {
            get
            {
                return (DistanceOrCountOfSets / WeightOfPerson) * _kkal * Time;
            }
        }

        #endregion
    }
}
