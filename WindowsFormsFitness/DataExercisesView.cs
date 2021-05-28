using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness;
using System.ComponentModel;

namespace WindowsFormsFitness
{
    /// <summary>
    /// Класс создания таблицы
    /// </summary>
    public static class DataExercisesView
    {
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="exercises">списко упражнений</param>
        /// <param name="dataGridView">датагрид</param>
        public static void CreateTable(BindingList<ExercisesBase> exercises,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = exercises;

            dataGridView.Columns[0].DataPropertyName = "DistanceOrCountOfSets";
            dataGridView.Columns[1].DataPropertyName = "Time";
            dataGridView.Columns[2].DataPropertyName = "WeightPerson";
            dataGridView.Columns[3].DataPropertyName = "Description";
            dataGridView.Columns[4].DataPropertyName = "KkalCalculation";

            dataGridView.Columns[0].HeaderText = "Расстояние или количество подходов";
            dataGridView.Columns[1].HeaderText = "Время выполнения";
            dataGridView.Columns[2].HeaderText = "Вес человека";
            dataGridView.Columns[3].HeaderText = "Упражнение";
            dataGridView.Columns[4].HeaderText = "Рассчитанные калории";

            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[1].Width = 90;

            dataGridView.DefaultCellStyle.Format = "0.00";

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
