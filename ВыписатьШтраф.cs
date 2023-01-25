using lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{

    public partial class ВыписатьШтраф : Form
    {
        Automobil машина;
        public ВыписатьШтраф(Automobil _машина)
        {
            InitializeComponent();
            машина = _машина;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int id = машина.GetID();
            string tableName = машина.GetИмяТаблицы();
            машина.Штраф(Decimal.Parse(textBox1.Text),tableName,id);
            }
            catch {
                MessageBox.Show("Введён неверный формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { 
                Close();
            }
        }

    }
}
