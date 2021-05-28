using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms; 
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Fitness;
using System.Threading;
using System.Net.Http.Headers;

namespace WindowsFormsFitness
{
    public partial class FormCalorieCalculation : Form
    {
        /// <summary>
        /// Лист с параметрами упражнения 
        /// </summary>
        private BindingList<ExercisesBase> _exercises =
            new BindingList<ExercisesBase>();

        /// <summary>
        /// Загрузка формы
        /// </summary>
        public FormCalorieCalculation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// открытие формы расчёта параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseExercise_Click(object sender, EventArgs e)
        {
            var exercise = new AddExercise();

            if (exercise.ShowDialog() == DialogResult.OK)
            {
                _exercises.Add(exercise.ExerciseDone);
            }
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Удаление элементов списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var deleteCount = DataExercisesView.SelectedRows.Count;

            for (int i = 0; i < deleteCount; i++)
            {
                _exercises.RemoveAt(DataExercisesView.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Сохранение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string path = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);
                saveFileDialog.InitialDirectory = path;
                saveFileDialog.Filter = "Exercises files " +
                    "(*.fit)|*.fit|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var exercises = new List<ExercisesBase>(_exercises);
                    var formatter = new BinaryFormatter();
                    var fileSave = saveFileDialog.FileName;
                    using (var fileStream = new FileStream(
                        fileSave, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fileStream, exercises);
                        MessageBox.Show("Файл успешно сохранен.");
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Exercises files (*.fit)|*.fit";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                        {
                            var newExercises =
                                (List<ExercisesBase>)formatter.
                                Deserialize(fileStream);

                            foreach (var exercise in newExercises)
                            {
                                _exercises.Add(exercise);
                            }
                        }

                        DataExercisesView.DataSource = _exercises;
                    }
                    catch
                    {
                        MessageBox.Show("Файл поврежден, проверьте структуру файла!");
                    }
                }
            }
        }

        /// <summary>
        /// Открытие формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var search = new DataSearchForm(_exercises);
            search.Show();
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalorieCalculation_Load(object sender, EventArgs e)
        {
            DataExercisesView.CreateTable(_exercises, DataExercisesView);
        }
        
    }
}
