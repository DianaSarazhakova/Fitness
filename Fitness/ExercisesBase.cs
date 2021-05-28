using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    /// <summary>
    /// Базовый класс, который содержит основные параметры расчётов
    /// </summary>
    public abstract class ExercisesBase
    {
        #region Константы

        /// <summary>
        /// Минимальный вес
        /// </summary>
        public const double MinWeightOfPerson = 14.3;

        /// <summary>
        /// Максимальный вес 
        /// </summary>
        public const double MaxWeightOfPerson = 450;

        #endregion

        #region Поля

        /// <summary>
        /// Поле расстояние или количество подходов 
        /// </summary>
        private double _distanceOrCountOfSets;

        /// <summary>
        /// время тренировки
        /// </summary>
        private double _time;

        /// <summary>
        /// поле вес человека
        /// </summary>
        private double _weightOfPerson;

        #endregion

        #region Свойства

        /// <summary>
        /// Расстояние или количество подходов 
        /// </summary>
        public double DistanceOrCountOfSets
        {
            get
            {
                return _distanceOrCountOfSets;
            }

            set
            {
                _distanceOrCountOfSets = CheckValue(value);
            }
        }               

        /// <summary>
        /// Время
        /// </summary>
        public double Time
        {
            get
            {
                return _time;
            }

            set
            {
                _time = CheckValue(value);
            }
        }        

        /// <summary>
        /// Вес человека
        /// </summary>
        public double WeightOfPerson
        {
            get
            {
                return _weightOfPerson;
            }

            set
            {
                _weightOfPerson = CheckСorrectness(value, MinWeightOfPerson,
                    MaxWeightOfPerson);
            }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Проверка значений
        /// </summary>
        /// <param name="value">Переданное значение</param>
        /// <returns>Проверенное значение</returns>
        protected double CheckValue(double value)
        {

            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                throw new ArgumentException(
                    "Значение не может быть неопределенным");
            }

            if (value < 0)
            {
                throw new ArgumentException(
                    "Значение не может быть отрицательным");
            }

            return value;
        }

        /// <summary>
        /// Проверка на вхождение в правильный диапазон значений
        /// </summary>
        /// <param name="value"> Введенный параметр</param>
        /// <returns>Проверенный параметр</returns>
        public static double CheckСorrectness(double value, double min, double max)
        {
            if (value < min)
            {
                throw new ArgumentException("Значение не может быть " +
                    $"меньше {min}.");
            }
            if (value > max)
            {
                throw new ArgumentException("Значение не может быть " +
                    $"больше {max}.");
            }
            return value;
        }

        /// <summary>
        /// Расчёт калорий
        /// </summary>
        /// <returns></returns>
        public virtual double CalculationOfKkal { get; }

        #endregion

    }
}
