namespace WF7
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelInfo = new Label();
            labelSeconds = new Label();
            labelHours = new Label();
            labelMinutes = new Label();
            labelTime = new Label();
            buttonStart = new Button();
            comboBoxHours = new ComboBox();
            comboBoxMinutes = new ComboBox();
            comboBoxSeconds = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.Location = new Point(138, 71);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(498, 25);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Установите желаемое время и нажмите кнопку \"Старт\":";
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeconds.Location = new Point(501, 124);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(90, 25);
            labelSeconds.TabIndex = 1;
            labelSeconds.Text = "Секунды:";
            // 
            // labelHours
            // 
            labelHours.AutoSize = true;
            labelHours.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHours.Location = new Point(138, 122);
            labelHours.Name = "labelHours";
            labelHours.Size = new Size(61, 25);
            labelHours.TabIndex = 2;
            labelHours.Text = "Часы:";
            // 
            // labelMinutes
            // 
            labelMinutes.AutoSize = true;
            labelMinutes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMinutes.Location = new Point(325, 124);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(85, 25);
            labelMinutes.TabIndex = 3;
            labelMinutes.Text = "Минуты:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ForeColor = Color.FromArgb(192, 0, 0);
            labelTime.Location = new Point(308, 283);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(97, 25);
            labelTime.TabIndex = 4;
            labelTime.Text = "Осталось:";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(308, 217);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(169, 36);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // comboBoxHours
            // 
            comboBoxHours.FormattingEnabled = true;
            comboBoxHours.Location = new Point(205, 124);
            comboBoxHours.Name = "comboBoxHours";
            comboBoxHours.Size = new Size(41, 23);
            comboBoxHours.TabIndex = 6;
            comboBoxHours.KeyPress += comboBox_KeyPress;
            comboBoxHours.Leave += comboBox_Leave;
            // 
            // comboBoxMinutes
            // 
            comboBoxMinutes.FormattingEnabled = true;
            comboBoxMinutes.Location = new Point(416, 126);
            comboBoxMinutes.Name = "comboBoxMinutes";
            comboBoxMinutes.Size = new Size(41, 23);
            comboBoxMinutes.TabIndex = 7;
            comboBoxMinutes.KeyPress += comboBox_KeyPress;
            comboBoxMinutes.Leave += comboBox_Leave;
            // 
            // comboBoxSeconds
            // 
            comboBoxSeconds.FormattingEnabled = true;
            comboBoxSeconds.Location = new Point(597, 126);
            comboBoxSeconds.Name = "comboBoxSeconds";
            comboBoxSeconds.Size = new Size(41, 23);
            comboBoxSeconds.TabIndex = 8;
            comboBoxSeconds.KeyPress += comboBox_KeyPress;
            comboBoxSeconds.Leave += comboBox_Leave;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxSeconds);
            Controls.Add(comboBoxMinutes);
            Controls.Add(comboBoxHours);
            Controls.Add(buttonStart);
            Controls.Add(labelTime);
            Controls.Add(labelMinutes);
            Controls.Add(labelHours);
            Controls.Add(labelSeconds);
            Controls.Add(labelInfo);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Таймер обратного отсчета";
            Load += mainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private Label labelSeconds;
        private Label labelHours;
        private Label labelMinutes;
        private Label labelTime;
        private Button buttonStart;
        private ComboBox comboBoxHours;
        private ComboBox comboBoxMinutes;
        private ComboBox comboBoxSeconds;
        private System.Windows.Forms.Timer timer1;
    }
}