namespace WF7
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public DateTime timerValue; //время для отсчета
        public DateTime timerNullValue = new DateTime(2020, 07, 11, 0, 0, 0);//нулевое значение
        public TimeSpan oneSecond = new TimeSpan(0, 0, 1); //интервал в 1 секунду
        public bool IsTimerOn = false;	//таймер не установлен


        private void mainForm_Load(object sender, EventArgs e)
        {
            //заполнение списка значениями часов
            for (int i = 0; i <= 24; i++) comboBoxHours.Items.Add(i);

            //заполнение списка значениями минут
            for (int i = 0; i <= 59; i++) comboBoxMinutes.Items.Add(i);

            //заполнение списка значениями секунд
            for (int i = 0; i <= 59; i++) comboBoxSeconds.Items.Add(i);

            //установка начального значения для всех списков, равного первому пункту
            comboBoxHours.SelectedIndex = comboBoxMinutes.SelectedIndex = comboBoxSeconds.SelectedIndex = 0;

            //до начала отсчета скрываем вывод времени
            labelTime.Visible = false;
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox cmbBox = (dynamic)sender; //создаем общий объект для выпадающих списков
                                               //разрешаем ввод только 2х цифр и нажатие клавиши backspace
            if ((((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != '\b')) || ((cmbBox.Text.Length == 2) && (e.KeyChar != '\b')))
            {
                e.Handled = true; //событие не требует передачи обработчику по умолчанию
            }
        }
        private void comboBox_Leave(object sender, EventArgs e)
        {
            ComboBox cmbBox = (dynamic)sender;  //создаем общий объект для выпадающих списков

            if (cmbBox.Text == "")  //если в поле списка введено пустое значение
                buttonStart.Enabled = false;    //блокируем кнопку "старт" else	//иначе
            buttonStart.Enabled = true; //снимаем блокировку
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerValue == timerNullValue)   //если время стало равно 0:00:00
            {
                timer1.Enabled = false; //выключаем таймер  
                MessageBox.Show("Время вышло"); //выводим сообщение на экран 
                buttonStart.Text = "Старт";
                IsTimerOn = false;  //сбрасываем флаг (таймер не установлен) 
                labelTime.Visible = false;
            }
            else
            {
                timerValue = timerValue - oneSecond;    //уменьшаем время на 1 секунду 
                                                        //выводим время на экран
                labelTime.Text = "Осталось: " + System.Convert.ToString(timerValue.TimeOfDay);
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!IsTimerOn) //если таймер не установлен
            {
                //сбрасываем переменную, содержащую время
                timerValue = new DateTime(2020, 07, 11, 0, 0, 0);

                //устанавливаем количество часов
                timerValue = timerValue.AddHours(System.Convert.ToInt32(comboBoxHours.Text));

                //устанавливаем количество минут
                timerValue = timerValue.AddMinutes(System.Convert.ToInt32(comboBoxMinutes.Text));

                //устанавливаем количество секунд
                timerValue = timerValue.AddSeconds(System.Convert.ToInt32(comboBoxSeconds.Text));

                //выводим на экран время

                labelTime.Text = "Осталось: " + System.Convert.ToString(timerValue.TimeOfDay);
                timer1.Enabled = true; //запускаем таймер
                IsTimerOn = true;
                buttonStart.Text = "Пауза";
                labelTime.Visible = true;
            }
            else
                if (IsTimerOn && timer1.Enabled)    //если таймер установлен и запущен
            {
                timer1.Enabled = false; //делаем паузу
                buttonStart.Text = "Продолжить";
            }
            else
                    if (IsTimerOn && !timer1.Enabled) //если таймер установлен и не запущен
            {
                timer1.Enabled = true; //возобновляем обратный отсчет
                buttonStart.Text = "Пауза";
            }
        }
    }
}