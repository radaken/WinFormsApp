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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Пройти_ТехОсмотр : Form
    {
        Automobil машина;
        public Пройти_ТехОсмотр(Automobil _машина)
        {
            InitializeComponent();
            машина = _машина;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Если ТО не пройдено, передаём -1 и закрываем
            машина.ТехОсмотр(-1);
            Close();
        }

        private void ТОФорма_btn_пройти_Click(object sender, EventArgs e)
        {
            try
            {
                //Вставляем год техосмотра
                машина.ТехОсмотр(Int32.Parse(ТОФорма_textBox.Text));
            }
            catch
            {
                MessageBox.Show("Введён неверный формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
        }
    }
}
