using Newtonsoft.Json;
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
    public partial class answer : Form
    {
        List<student> students = new List<student>();
        int indexStudent;
        string last_name;
        string first_name;
        string patronymic;
        string Answer;
        public answer(List<student> _students, int _indexStudent, string _last_name, string _first_name, string _patronymic, string _Answer)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            students = _students;
            indexStudent = _indexStudent;
            last_name = _last_name;
            first_name = _first_name;
            patronymic = _patronymic;
            Answer = _Answer;
        }

        private void answer_Load(object sender, EventArgs e)
        {
            fio_label.Text = last_name + " " + first_name + " " + patronymic;
            answer_textBox.Text = Answer;
        }

        //вызывается при нажатии на кнопку "Поставить оценку"
        private void button_mark_Click(object sender, EventArgs e)
        {
            string mark = mark_textBox.Text;
            if (mark_textBox.Text != "")
            {
                //запись поставленой оценки в атрибут mark соответствующего студента
                students[indexStudent].mark = Convert.ToInt32(mark);
                //сохранение изменений в файл с данными студентов
                string json = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText("database.json", json);
                MessageBox.Show("Изменения успешно сохранены", "Уведомление", MessageBoxButtons.OK);
            }
        }
    }
}
