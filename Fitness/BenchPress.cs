using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    /// <summary>
    /// Класс параметров жима штанги
    /// </summary>
    public class BenchPress : ExercisesBase
    {
        #region Константы

        /// <summary>
        /// Минимальный вес
        /// </summary>
        public const double MinWeightOfBarbell = 5.8;

        /// <summary>
        /// Максимальный вес 
        /// </summary>
        public const double MaxWeightOfBarbell = 2844;

        #endregion

        #region Поля

        /// <summary>
        /// Поле вес штанги
        /// </summary>
        private double _weightOfBarbell;

        #endregion

        #region Свойства

        /// <summary>
        /// Вес штанги
        /// </summary>
        public double WeightOfBarbell
        {
            get
            {
                return _weightOfBarbell;
            }

            set
            {
                _weightOfBarbell = CheckСorrectness(value, MinWeightOfBarbell,
                    MaxWeightOfBarbell);
            }
        }

        #endregion

        #region Коструктор

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="weightOfBarbell">Вес штанги</param>
        /// <param name="weightOfPerson">Вес человека</param>
        /// <param name="time">Время занятия</param>
        /// <param name="distanceOrCountOfSets">Подходы</param>
        public BenchPress(double weightOfBarbell, double weightOfPerson,
            double time, double distanceOrCountOfSets)
        {
            WeightOfBarbell = weightOfBarbell;
            WeightOfPerson = weightOfPerson;
            Time = time;
            DistanceOrCountOfSets = distanceOrCountOfSets;
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
                return (WeightOfBarbell / WeightOfPerson) * DistanceOrCountOfSets * Time;
            }

        }        

        #endregion
    }
}
