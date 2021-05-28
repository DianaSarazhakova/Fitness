using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness;

namespace WindowsFormsFitness
{
    /// <summary>
    /// Класс, описывающий форму поиска
    /// </summary>
    public partial class DataSearchForm : Form
    {
        /// <summary>
        /// Cписок основной формы
        /// </summary>
        private BindingList<ExercisesBase> _exercises;

        /// <summary>
        /// Список с результатами поиска
        /// </summary>
        private BindingList<ExercisesBase> _exercisesSearch =
           new BindingList<ExercisesBase>();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="exercises"></param>
        public DataSearchForm(BindingList<ExercisesBase> exercises)
        {
            InitializeComponent();

            _exercises = exercises;
        }

        /// <summary>
        /// Метод начала поиска
        /// </summary>
        private void Search()
        {
            _exercisesSearch.Clear();

            try
            {
                foreach (var row in _exercises)
                {
                    var isTime =
                        radioButton1.Checked
                        && row.Time == Convert.ToDouble(SearchTextBox.Text);
                    var isWeight =
                        radioButton2.Checked
                        && row.WeightOfPerson == Convert.ToDouble(
                            SearchTextBox.Text);

                    if (isTime || isWeight)
                    {
                        _exercisesSearch.Add(row);
                    }

                    dataGridView1.DataSource = _exercisesSearch;
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message} " +
                     $"\nВведите десятичное число!(Через запятую)");
            }
        }

        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataSearchForm_Load(object sender, EventArgs e)
        {
            DataExercisesView.CreateTable(_exercisesSearch, dataGridView1);            
        }
    }
}
