using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness;

namespace TestFitness
{
    /// <summary>
    /// Ввод параметров расчёта
    /// </summary>
    public static class ConsoleLoader
    {
        #region Свойства

        /// <summary>
        /// Ввод параметров для бега
        /// </summary>
        /// <returns>Параметры</returns>
        public static Run RunParameters()
        {
            var exerciseParameters = new Run(Run.MaxHeartRate, ExercisesBase.MinWeightOfPerson, 
                Run.MinAge, 0, 0);
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write($"Пульс при беге, %: ");
                    exerciseParameters.HeartRate = SetDoubleValue();
                }), 
                
                new Action(() =>
                {
                    Console.Write("Вес человека, кг " +
                    $"(от {ExercisesBase.MinWeightOfPerson} до {ExercisesBase.MaxWeightOfPerson}): ");
                    exerciseParameters.WeightOfPerson = SetDoubleValue();
                }),

                new Action(() =>
                {
                    Console.Write("Возраст человека " +
                    $"(от {Run.MinAge} до {Run.MaxAge}): ");
                    exerciseParameters.Age = int.Parse(Console.ReadLine());
                }),

                 new Action(() =>
                {
                    Console.Write($"Время, с: ");
                    exerciseParameters.Time = SetDoubleValue();
                }),                

                 new Action(() =>
                {
                    Console.Write($"Дистанция, км: ");
                    exerciseParameters.DistanceOrCountOfSets = SetDoubleValue();
                })
            };

            actions.ForEach(SetValue);
            return exerciseParameters;
        }

        /// <summary>
        /// Ввод параметров жима лежа
        /// </summary>
        /// <returns>параметры</returns>
        public static BenchPress BenchPressParameters()
        {
            var exerciseParameters = new BenchPress(BenchPress.MinWeightOfBarbell, 
                BenchPress.MaxWeightOfPerson, 0, 0);
            var actions = new List<Action>()
            {
                new Action(() =>
                 {
                     Console.Write($"Вес штанги, кг " +
                     $"(от {BenchPress.MinWeightOfBarbell} до {BenchPress.MaxWeightOfBarbell}): ");
                     exerciseParameters.WeightOfBarbell = SetDoubleValue();
                 }),

                new Action(() =>
                 {
                     Console.Write($"Вес человека, кг " +
                     $"(от {ExercisesBase.MinWeightOfPerson} до {ExercisesBase.MaxWeightOfPerson}): ");
                     exerciseParameters.WeightOfPerson = SetDoubleValue();
                 }),

                new Action(() =>
                {
                    Console.Write($"Количество подходов: ");
                    exerciseParameters.DistanceOrCountOfSets= SetDoubleValue();
                }),

                 new Action(() =>
                 {
                     Console.Write($"Время, с: ");
                     exerciseParameters.Time = SetDoubleValue();
                 }),

            };

            actions.ForEach(SetValue);
            return exerciseParameters;
        }

        /// <summary>
        /// Ввод параметров плавания
        /// </summary>
        /// <returns>параметры</returns>
        public static Swimming SwimmingParameters()
        {
            var exerciseParameters = new Swimming(0, Swimming.MinWeightOfPerson,
                0, SwimmingStyles.Backstroke);
            var actions = new List<Action>()
            {    
                new Action(() =>
                {
                    Console.Write($"Расстояние, м: ");
                    exerciseParameters.DistanceOrCountOfSets = SetDoubleValue();
                }),

                 new Action(() =>
                {
                    Console.Write($"Время, с: ");
                    exerciseParameters.Time = SetDoubleValue();
                }),                

                  new Action(() =>
                {
                    Console.Write($"Вес человека, кг " +
                     $"(от {ExercisesBase.MinWeightOfPerson} до {ExercisesBase.MaxWeightOfPerson}): ");
                    exerciseParameters.WeightOfPerson = SetDoubleValue();
                }),

                  new Action(() =>
                {
                    Console.Write($"Стиль плавания:\n" +
                    $"1 - Плавание на спине\n" +
                    $"2 - Брасс\n" +
                    $"3 - Баттерфляй\n" +
                    $"4 - Кроль\n" +
                    $"5 - Плавание на боку\n");
                    exerciseParameters.SwimmingStyle = ChooseSwimmingStyle();
                })

            };

            actions.ForEach(SetValue);
            return exerciseParameters;
        }

        #endregion

        #region Методы                

        /// <summary>
        /// Ввод типа плавания
        /// </summary>
        /// <returns>Калории при данном типе</returns>
        private static SwimmingStyles ChooseSwimmingStyle()
        {
            int style = int.Parse(Console.ReadLine());
            switch (style)
            {
                case 1:
                    {
                        return SwimmingStyles.Backstroke;
                    }
                case 2:
                    {
                        return SwimmingStyles.Breaststroke;
                    }
                case 3:
                    {
                        return SwimmingStyles.Butterfly;
                    }
                case 4:
                    {
                        return SwimmingStyles.Crawl;
                    }
                case 5:
                    {
                        return SwimmingStyles.Sidestroke;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Выбран неизвестный стиль " +
                                $"плавания.");
                    }
            }
        }

        /// <summary>
        /// Ввод дробного числа с консоли
        /// </summary>
        /// <returns>введенное число</returns>
        private static double SetDoubleValue()
        {
            var buffer = double.Parse(Console.ReadLine().Replace('.', ','));

            return buffer;
        }

        /// <summary>
        /// Задание значения
        /// </summary>
        /// <param name="action">Делегат с заданием параметраы</param>
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"\n{exception.Message}\n");
                }
            }
        }

        #endregion
    }
}
