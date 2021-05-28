using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness;

namespace WindowsFormsFitness
{
    /// <summary>
    /// Класс, формирующий случайное упражнение
    /// </summary>
    public static class RandomExercise
    {
        /// <summary>
        /// Случайное число
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Константа для максимального значения
        /// </summary>
        private const int _max = 1000;

        /// <summary>
        /// Генерация случайной активности
        /// </summary>
        /// <returns></returns>
        public static ExercisesBase CreateAction()
        {
            int typeExercise = _random.Next(0, 3);
            int typeSwimming = _random.Next(1, 5);

            switch (typeExercise)
            {
                case 0:
                    {
                        var randomRun = new Run(60, 14.3, 0,
                            0, 0)
                        {
                            HeartRate = _random.NextDouble() * _max,
                            WeightOfPerson = _random.NextDouble() *
                                ExercisesBase.MaxWeightOfPerson + ExercisesBase.MinWeightOfPerson,
                            Age = _random.Next(),
                            Time = _random.NextDouble() * _max,
                            DistanceOrCountOfSets = _random.NextDouble()
                        };

                        return randomRun;

                    }
                case 1:
                    {
                        var randomBenchPress = new BenchPress(0, 14.3,
                            0, 0)
                        {
                            WeightOfBarbell = _random.NextDouble() * _max,
                            WeightOfPerson = _random.NextDouble() *
                                ExercisesBase.MaxWeightOfPerson + ExercisesBase.MinWeightOfPerson,
                            Time = _random.NextDouble() * _max,
                            DistanceOrCountOfSets = _random.NextDouble() * _max
                        };

                        return randomBenchPress;
                    }
                case 2:
                    {
                        var randomSwimming = new Swimming(0, 14.3,
                            0, SwimmingStyles.Backstroke)
                        {
                            DistanceOrCountOfSets = _random.NextDouble() * _max,
                            WeightOfPerson = _random.NextDouble() *
                                ExercisesBase.MaxWeightOfPerson + ExercisesBase.MinWeightOfPerson,
                            Time = _random.NextDouble() * _max,                            
                            SwimmingStyle = (SwimmingStyles)typeSwimming
                        };

                        return randomSwimming;
                    }
                default:
                    {
                        throw new ArgumentException();
                    }
            }
        }
    }
}
