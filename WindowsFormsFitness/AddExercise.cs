using System.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fitness;

namespace WindowsFormsFitness
{
    public partial class AddExercise : Form
    {

        /// <summary>
        /// Поле для создания расчёта калорий
        /// </summary>
        private ExercisesBase _exercise;

        /// <summary>
        /// Свойство 
        /// </summary>
        public ExercisesBase ExerciseDone
        {
            get
            {
                return _exercise;
            }
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddExercise()
        {
            InitializeComponent();
            RadioButtonRun.Checked = true;
            numericUpDownWeight.Value = Convert.ToDecimal(
                ExercisesBase.MinWeightOfPerson);
            ComboBoxSwimmingStyles.DataSource = Enum.GetValues(
                typeof(SwimmingStyles));
            ComboBoxSwimmingStyles.SelectedIndex = -1;

            #if !DEBUG
            RandomButton.Visible = false;
            #endif
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ввод данных по нажатию клавиши Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertData();
            }
        }

        /// <summary>
        /// Внесение параметров упражнения
        /// </summary>
        private void InsertData()
        {
            _exercise.WeightOfPerson =
                Convert.ToDouble(numericUpDownWeight.Text);

            _exercise.Time = Convert.ToDouble(numericUpDownTime.Text);

            if (_exercise is Run run)
            {
                run.HeartRate =
                    Convert.ToDouble(numericUpDownHeartRate.Text);
                run.DistanceOrCountOfSets =
                    Convert.ToDouble(numericUpDownDistance.Text);
            }

            if (_exercise is BenchPress benchPress)
            {
                benchPress.WeightOfBarbell =
                    Convert.ToDouble(numericUpDownGirya.Text);
                benchPress.DistanceOrCountOfSets =
                    Convert.ToDouble(numericUpDownPodxody.Text);
            }

            if (_exercise is Swimming swimming)
            {
                swimming.DistanceOrCountOfSets =
                    Convert.ToDouble(numericUpDownDistance.Text);

                if (ComboBoxSwimmingStyles.SelectedIndex != -1)
                {
                    swimming.SwimmingStyle =
                        (SwimmingStyles)ComboBoxSwimmingStyles.SelectedIndex + 1;
                }
            }
        }

        /// <summary>
        /// Внесение упражнения в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            InsertData();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Переключение вида упражнения с / на
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonRun_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == RadioButtonRun)
            {
                _exercise = new Run(60, 14.3, 0, 0, 0);
            }
            else if (sender == RadioButtonSwimming)
            {
                _exercise = new Swimming(0, 14.3, 0, SwimmingStyles.Backstroke);
            }
            else if (sender == RadioButtonBenchPress)
            {
                _exercise = new BenchPress(5.8, 14.3, 0, 0);
            }

            ChangeEnabledPropertyOfTextBoxes();
            InsertData();
            TextBoxResult.Text = _exercise.CalculationOfKkal.ToString(
                                 "0.00");
        }

        /// <summary>
        /// Включение / выключение полей при изменении вида упражнения
        /// </summary>
        private void ChangeEnabledPropertyOfTextBoxes()
        {
            numericUpDownHeartRate.Enabled = RadioButtonRun.Checked;
            numericUpDownDistance.Enabled = (RadioButtonRun.Checked ||
                RadioButtonSwimming.Checked);
            numericUpDownPodxody.Enabled = RadioButtonBenchPress.Checked;
            numericUpDownGirya.Enabled = RadioButtonBenchPress.Checked;
            ComboBoxSwimmingStyles.Enabled = RadioButtonSwimming.Checked;
        }

        /// <summary>
        /// Заполнение параметров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (sender == numericUpDownWeight)
            {
                _exercise.WeightOfPerson = Convert.ToDouble(
               numericUpDownWeight.Value);
            }

            else if (sender == numericUpDownTime)
            {
                _exercise.Time = Convert.ToDouble(
                numericUpDownTime.Value);
            }

            else if (sender == numericUpDownHeartRate)
            {
                (_exercise as Run).HeartRate = Convert.ToInt32(
                numericUpDownHeartRate.Value);
            }

            else if (sender == numericUpDownDistance)
            {
                _exercise.DistanceOrCountOfSets = Convert.ToDouble(
                numericUpDownDistance.Value);
            }

            else if (sender == numericUpDownGirya)
            {
                (_exercise as BenchPress).DistanceOrCountOfSets = Convert.ToDouble(
                numericUpDownGirya.Value);
            }

            else if (sender == numericUpDownPodxody)
            {
                _exercise.DistanceOrCountOfSets = Convert.ToDouble(
                numericUpDownPodxody.Value);
            }

            TextBoxResult.Text = _exercise.CalculationOfKkal.ToString("0.00");

        }

        /// <summary>
        /// Изменение значения типа плавания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSwimmingStyles_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (_exercise is Swimming)
            {
                (_exercise as Swimming).SwimmingStyle =
                    (SwimmingStyles)(ComboBoxSwimmingStyles.SelectedIndex + 1);

                TextBoxResult.Text =
                    _exercise.CalculationOfKkal.ToString("0.00");
            }
        }

        /// <summary>
        /// Генерация случайной активности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            _exercise = RandomExercise.CreateAction();
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
