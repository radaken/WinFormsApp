using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
//********************Подключаем нашу DLL************
using lib;
namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        //Запоняем нашу строку подключения: локальная база данных Microsoft SQL, таблица находится в наших данных с именем Database1.mdf, и у нас все безопасно
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\Database1.mdf; Integrated Security = True";
 
        public Automobil машина = new Automobil();
        public Form1()
        {
            InitializeComponent();
            //Заменяем нашу строку подключения на ту, что объявили в форме. Дополнительное резервирование или см. Рефакторинг
            машина.setConnectionString(connectionString);
        }

        private void button_ВыписатьШтраф_Click(object sender, EventArgs e)
        {
            //Везде на кнопках будет одно и тоже:
            //Сначала создаем нашу форму и передаем текущее состояние класса (экземпляр, снимок класса, как угодно)
            ВыписатьШтраф ШтрафФорма = new ВыписатьШтраф(машина);
            //Вешаем на него события "когда форма закроется, выполни функцию Form_Closed"
            ШтрафФорма.FormClosed += new FormClosedEventHandler(Form_Closed);
            //Вызываем модальное окно
            ШтрафФорма.ShowDialog();
        }

        private void button_ПройтиТО_Click(object sender, EventArgs e)
        {
            //Тоже самое
            Пройти_ТехОсмотр ТехОсмотрФорма = new Пройти_ТехОсмотр(машина);
            ТехОсмотрФорма.FormClosed += new FormClosedEventHandler(Form_Closed);
            ТехОсмотрФорма.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.carDB". При необходимости она может быть перемещена или удалена.
            //Это не трогаем. Без него работает нестабильно. См. Рефакторинг
            this.carDBTableAdapter.Fill(this.database1DataSet.carDB);

        }

        private void button_продатьАвто_Click(object sender, EventArgs e)
        {
            //Тоже самое
            ПродажаФорма _ПродажаФорма = new ПродажаФорма(машина);
            _ПродажаФорма.FormClosed += new FormClosedEventHandler(Form_Closed);
            _ПродажаФорма.ShowDialog();

        }

        public void button_получитьДанныеОбАвто_Click(object sender, EventArgs e)
        {
            получитьДанныеОбАвто();
        }
        private void получитьДанныеОбАвто(){
            //Узнаем выбранный ID из выпадашки
            int _id = Int32.Parse(comboBox1.Text);
            //Получаем данные из БД с соответствующим ID
            DataTable данныеМашины = машина.ПолучитьДанные("carDB", _id);
            //Заполняем массив объектов
            var машинаПоID = данныеМашины.Select("ID = " + _id)[0].ItemArray;
            //Заполняем снимок класса (DLL)
            машина.SetID(Int32.Parse(машинаПоID[0].ToString()));
            машина.SetМарка(машинаПоID[1].ToString());
            машина.SetМодель(машинаПоID[2].ToString());
            машина.SetГодВыпуска(Int32.Parse(машинаПоID[3].ToString()));
            машина.SetГодПрохожденияТехОсмотра(Int32.Parse(машинаПоID[4].ToString()));
            машина.SetВладелец(машинаПоID[5].ToString());
            машина.SetДействующиеШтрафы(Decimal.Parse(машинаПоID[6].ToString())); //Парсинг по таким числам 123.45, валюта в общем

            //Заполняем UI
            textBox_марка.Text = машина.GetМарка();
            textBox_модель.Text = машина.GetМодель();
            textBox_годВыпуска.Text = машина.GetГодВыпуска().ToString();

            //Условие на прохождение техосмотра
            if (машина.GetГодПрохожденияТехОсмотра() != -1)
            {
                textBox_годТО.Text = машина.GetГодПрохожденияТехОсмотра().ToString();
            }
            else { textBox_годТО.Text = "ТЕХОСМОТР НЕ ПРОЙДЕН"; }


            label_fineamount.Text = машина.GetДействующиеШтрафы().ToString();
            textBox_ФИОВладельца.Text = "";
        }
        //Когда форма закрывается, обновляем данные
        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            получитьДанныеОбАвто();
        }

        //Функция очистки
        private void btn_Очистить_Click(object sender, EventArgs e)
        {
            label_fineamount.Text = "";
            textBox_годВыпуска.Text = "";
            textBox_годТО.Text = "";
            textBox_марка.Text = "";
            textBox_модель.Text = "";
            textBox_ФИОВладельца.Text = "";
            //Обнуляем все текстовые поля и класс (DLL)
            машина = new Automobil();
        }

        //Функция создания
        private void btn_Создать_Click(object sender, EventArgs e)
        {
            //Вставляем все текстовые поля в класс
            машина.SetМодель(textBox_модель.Text);
            машина.SetВладелец(textBox_ФИОВладельца.Text);
            машина.SetМарка(textBox_марка.Text);
            машина.SetГодВыпуска(Int32.Parse(textBox_годВыпуска.Text));
            машина.SetТехОсмотрПройден(true); //Новая машина = пройденый техосмотр
            машина.SetГодПрохожденияТехОсмотра(Int32.Parse(textBox_годТО.Text));
            машина.SetДействующиеШтрафы(0); //Новая машина без штрафов
            машина.СоздатьАвто(); //Говорим DLL: запили тачку
        }

        //Отдельная функция для получения ФИО. Небезопасно, т.к. класс уже заполнен, см. Рефакторинг
        private void button_получитьФИО_Click(object sender, EventArgs e)
        {
            if (машина.GetВладелец() != "-1")
            {
                textBox_ФИОВладельца.Text = машина.GetВладелец();
            }
            else { textBox_ФИОВладельца.Text = "УТИЛИЗИРОВАН"; }
        }
    }

}
