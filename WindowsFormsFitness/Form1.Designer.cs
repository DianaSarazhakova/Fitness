
namespace WindowsFormsFitness
{
    partial class AddExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExercise));
            this.numericUpDownGirya = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPodxody = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeartRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.RandomButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonRun = new System.Windows.Forms.RadioButton();
            this.RadioButtonBenchPress = new System.Windows.Forms.RadioButton();
            this.RadioButtonSwimming = new System.Windows.Forms.RadioButton();
            this.ComboBoxSwimmingStyles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGirya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPodxody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeartRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownGirya
            // 
            this.numericUpDownGirya.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.numericUpDownGirya.Location = new System.Drawing.Point(478, 195);
            this.numericUpDownGirya.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownGirya.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownGirya.Name = "numericUpDownGirya";
            this.numericUpDownGirya.Size = new System.Drawing.Size(183, 29);
            this.numericUpDownGirya.TabIndex = 45;
            this.numericUpDownGirya.Value = new decimal(new int[] {
            58,
            0,
            0,
            65536});
            this.numericUpDownGirya.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownPodxody
            // 
            this.numericUpDownPodxody.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.numericUpDownPodxody.Location = new System.Drawing.Point(235, 195);
            this.numericUpDownPodxody.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPodxody.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPodxody.Name = "numericUpDownPodxody";
            this.numericUpDownPodxody.Size = new System.Drawing.Size(175, 29);
            this.numericUpDownPodxody.TabIndex = 44;
            this.numericUpDownPodxody.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownHeartRate
            // 
            this.numericUpDownHeartRate.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.numericUpDownHeartRate.Location = new System.Drawing.Point(235, 141);
            this.numericUpDownHeartRate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownHeartRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownHeartRate.Name = "numericUpDownHeartRate";
            this.numericUpDownHeartRate.Size = new System.Drawing.Size(175, 29);
            this.numericUpDownHeartRate.TabIndex = 43;
            this.numericUpDownHeartRate.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownHeartRate.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.numericUpDownDistance.Location = new System.Drawing.Point(478, 141);
            this.numericUpDownDistance.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(181, 29);
            this.numericUpDownDistance.TabIndex = 42;
            this.numericUpDownDistance.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RandomButton.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.RandomButton.Location = new System.Drawing.Point(478, 240);
            this.RandomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(183, 32);
            this.RandomButton.TabIndex = 41;
            this.RandomButton.Text = "Случайная активность";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox2.Controls.Add(this.numericUpDownTime);
            this.groupBox2.Controls.Add(this.numericUpDownWeight);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(222, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(451, 90);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обязательно к заполнению";
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTime.Location = new System.Drawing.Point(256, 53);
            this.numericUpDownTime.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(181, 29);
            this.numericUpDownTime.TabIndex = 26;
            this.numericUpDownTime.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.DecimalPlaces = 1;
            this.numericUpDownWeight.Location = new System.Drawing.Point(13, 53);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            594,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            143,
            0,
            0,
            65536});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(175, 29);
            this.numericUpDownWeight.TabIndex = 25;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            143,
            0,
            0,
            65536});
            this.numericUpDownWeight.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес человека,кг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время выполнения,с";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.CloseButton.Location = new System.Drawing.Point(586, 282);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 32);
            this.CloseButton.TabIndex = 39;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButton.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.OkButton.Location = new System.Drawing.Point(478, 282);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 32);
            this.OkButton.TabIndex = 38;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Akrobat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(232, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Затраченные калории";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Font = new System.Drawing.Font("Akrobat Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxResult.Location = new System.Drawing.Point(234, 264);
            this.TextBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(175, 29);
            this.TextBoxResult.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(474, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Вес гири";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(230, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Количество подходов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(474, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Дистанция";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Akrobat Light", 10.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(231, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Пульс";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox1.Controls.Add(this.RadioButtonRun);
            this.groupBox1.Controls.Add(this.RadioButtonBenchPress);
            this.groupBox1.Controls.Add(this.RadioButtonSwimming);
            this.groupBox1.Font = new System.Drawing.Font("Akrobat Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(157, 118);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид упражения";
            // 
            // RadioButtonRun
            // 
            this.RadioButtonRun.AutoSize = true;
            this.RadioButtonRun.Location = new System.Drawing.Point(5, 27);
            this.RadioButtonRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonRun.Name = "RadioButtonRun";
            this.RadioButtonRun.Size = new System.Drawing.Size(52, 26);
            this.RadioButtonRun.TabIndex = 9;
            this.RadioButtonRun.Text = "Бег";
            this.RadioButtonRun.UseVisualStyleBackColor = true;
            this.RadioButtonRun.CheckedChanged += new System.EventHandler(this.RadioButtonRun_CheckedChanged);
            // 
            // RadioButtonBenchPress
            // 
            this.RadioButtonBenchPress.AutoSize = true;
            this.RadioButtonBenchPress.Location = new System.Drawing.Point(5, 81);
            this.RadioButtonBenchPress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonBenchPress.Name = "RadioButtonBenchPress";
            this.RadioButtonBenchPress.Size = new System.Drawing.Size(111, 26);
            this.RadioButtonBenchPress.TabIndex = 11;
            this.RadioButtonBenchPress.Text = "Жим штанги";
            this.RadioButtonBenchPress.UseVisualStyleBackColor = true;
            this.RadioButtonBenchPress.CheckedChanged += new System.EventHandler(this.RadioButtonRun_CheckedChanged);
            // 
            // RadioButtonSwimming
            // 
            this.RadioButtonSwimming.AutoSize = true;
            this.RadioButtonSwimming.Location = new System.Drawing.Point(5, 54);
            this.RadioButtonSwimming.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonSwimming.Name = "RadioButtonSwimming";
            this.RadioButtonSwimming.Size = new System.Drawing.Size(91, 26);
            this.RadioButtonSwimming.TabIndex = 10;
            this.RadioButtonSwimming.Text = "Плавание";
            this.RadioButtonSwimming.UseVisualStyleBackColor = true;
            this.RadioButtonSwimming.CheckedChanged += new System.EventHandler(this.RadioButtonRun_CheckedChanged);
            // 
            // ComboBoxSwimmingStyles
            // 
            this.ComboBoxSwimmingStyles.BackColor = System.Drawing.Color.MintCream;
            this.ComboBoxSwimmingStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSwimmingStyles.Font = new System.Drawing.Font("Akrobat Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxSwimmingStyles.FormattingEnabled = true;
            this.ComboBoxSwimmingStyles.Location = new System.Drawing.Point(21, 194);
            this.ComboBoxSwimmingStyles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSwimmingStyles.Name = "ComboBoxSwimmingStyles";
            this.ComboBoxSwimmingStyles.Size = new System.Drawing.Size(183, 30);
            this.ComboBoxSwimmingStyles.TabIndex = 30;
            this.ComboBoxSwimmingStyles.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSwimmingStyles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Akrobat Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(22, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Стиль плавания";
            // 
            // AddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 447);
            this.Controls.Add(this.numericUpDownGirya);
            this.Controls.Add(this.numericUpDownPodxody);
            this.Controls.Add(this.numericUpDownHeartRate);
            this.Controls.Add(this.numericUpDownDistance);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxSwimmingStyles);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExercise";
            this.Text = "Добавить упражнение";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGirya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPodxody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeartRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownGirya;
        private System.Windows.Forms.NumericUpDown numericUpDownPodxody;
        private System.Windows.Forms.NumericUpDown numericUpDownHeartRate;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonRun;
        private System.Windows.Forms.RadioButton RadioButtonBenchPress;
        private System.Windows.Forms.RadioButton RadioButtonSwimming;
        private System.Windows.Forms.ComboBox ComboBoxSwimmingStyles;
        private System.Windows.Forms.Label label1;
    }
}