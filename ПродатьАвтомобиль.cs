using lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    
public partial class ПродажаФорма : Form
    {
        //Говорим: мы будем использовать класс Automobil (из DLL) с именем машина
        Automobil машина;
    public ПродажаФорма(Automobil _машина)
        {
            InitializeComponent();
            //В аргументах переданную машину заполняем в наш экземпляр (по ООП)
            машина = _машина;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Пытаемся продать
                машина.ПродатьАвтомобиль(textBox1.Text);
            }
            catch
            {
                //Если неверный формат выводим сообщение
                MessageBox.Show("Введён неверный формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //В любом случае закрываем форму
                Close();
            }
        }
    }
}
