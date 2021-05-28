using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    /// <summary>
    /// Класс для описания бега
    /// </summary>
    public class Run : ExercisesBase
    {
        #region Константы

        /// <summary>
        /// Минимальный пульс при беге
        /// </summary>
        public const double MinHeartRate = 60;

        /// <summary>
        /// Максимальный пульс при беге
        /// </summary>
        public const double MaxHeartRate = 85;

        /// <summary>
        /// Минимальный возраст бегуна
        /// </summary>
        public const int MinAge = 6;

        /// <summary>
        /// Максимальный возраст бегуна
        /// </summary>
        public const int MaxAge = 105;

        #endregion

        #region Поля

        /// <summary>
        /// Поле пуль при беге
        /// </summary>
        private double _heartRate;

        /// <summary>
        /// Возраст человека
        /// </summary>
        private int _age;

        #endregion

        #region Свойства

        /// <summary>
        /// Пульс при беге
        /// </summary>
        public double HeartRate
        {
            get
            {
                return _heartRate;
            }
            set
            {
                _heartRate = CheckСorrectness(value, MinHeartRate,
                    MaxHeartRate);
            }
        }

        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Convert.ToInt32(CheckСorrectness(value, MinAge, MaxAge));
            }
        }

        #endregion

        #region Кострукторы

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="heartRate">Пуль при беге</param>
        /// <param name="weightOfPerson">Вес человека</param>
        /// <param name="age">возраст человека</param>
        /// <param name="time">Время занятия</param>
        /// <param name="distanceOrCountOfSets">Расстояние</param>
        public Run(double heartRate, double weightOfPerson, int age,
                    double time, double distanceOrCountOfSets)
        {
            HeartRate = heartRate;
            WeightOfPerson = weightOfPerson;
            Time = time;
            DistanceOrCountOfSets = distanceOrCountOfSets;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Расчёт калорий при беге
        /// </summary>
        /// <returns>количество калорий</returns>
        public override double CalculationOfKkal
        {
            get
            {
                return WeightOfPerson * DistanceOrCountOfSets;
            }

        }

        /// <summary>
        /// Расчёт калорий при беге более точный
        /// </summary>
        /// <returns>количество калорий</returns>
        public double ExactCalculationOfKkal
        {
            get
            {
                return 0.014 * WeightOfPerson * Time * 
                    (0.12 * (208 - 0.7 * Age) * HeartRate / 100 - 7);
            }

        }

        #endregion
    }
}
