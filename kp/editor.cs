using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kp
{
    public partial class editor : Form
    {
        public editor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //загрузка заданий из файла
        private void editor_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("tasks.txt");
            foreach (string line in lines)
            {
                textBox_tasks.Text += line;
                textBox_tasks.Text += System.Environment.NewLine;
            }
        }

        //сохранение изменений в файл
        private void button_save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("tasks.txt");
            sw.WriteLine(textBox_tasks.Text);
            MessageBox.Show("Изменения успешно сохранены", "Уведомление", MessageBoxButtons.OK);
            sw.Close();
        }
    }
}
