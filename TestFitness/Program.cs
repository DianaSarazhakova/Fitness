using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness;

namespace TestFitness
{
    /// <summary>
    /// Тестирующий класс
    /// </summary>
    public class Program
    {
        /// <summary>
        /// точка вхождения в программу
        /// </summary>
        /// <param name="args">аргументы</param>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Выберите упражнение:\n" +
                    "1 - бег\n" +
                    "2 - плавание\n" +
                    "3 - жим штанги\n" +
                    "4 - чтобы выйти\n");

                var exercise = ChooseExercise();

                if (exercise is Run)
                {
                    var run = exercise as Run;
                    Console.WriteLine("Затраченные калории: " 
                        + exercise.CalculationOfKkal + ";\n" 
                        + "Более точный расчет калорий (через пульс): " 
                        + run.ExactCalculationOfKkal + ".");
                }
                else
                {
                    Console.WriteLine("Затраченные калории: " + exercise.CalculationOfKkal + ".");
                }
            }
        }

        /// <summary>
        /// Выбор упражнения
        /// </summary>
        /// <returns>Параметры упражнения</returns>
        private static ExercisesBase ChooseExercise()
        {
            while (true)
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            {
                                Console.WriteLine("Введите параметры для бега: ");
                                return ConsoleLoader.RunParameters();
                            }

                        case 2:
                            {
                                Console.WriteLine("Введите параметры для плавания: ");
                                return ConsoleLoader.SwimmingParameters();
                            }

                        case 3:
                            {
                                Console.WriteLine("Введите параметры для жима штанги: ");
                                return ConsoleLoader.BenchPressParameters();
                            }

                        case 4:
                            {
                                Environment.Exit(0);
                                break;
                            }

                        default:
                            {
                                throw new ArgumentException("Введите номер в диапазоне от 1 до 4.");
                            }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"\n{exception.Message}\n");
                }
            }
        }
    }
}
