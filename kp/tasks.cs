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
using Newtonsoft.Json;

namespace kp
{
    public partial class tasks : Form
    {
        List<student> students = new List<student>();
        int indexStudent;
        public tasks(List<student> _students, int _indexStudent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            students = _students;
            indexStudent = _indexStudent;
        }

        private void tasks_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("tasks.txt");
            foreach (string line in lines)
            {
                textBox_tasks.Text += line;
                textBox_tasks.Text += System.Environment.NewLine;
            }
            string str = students[indexStudent].answer;
            if (str != "")
            {
                textBox_answer.Text += str;
                textBox_answer.Text += System.Environment.NewLine;
            }
            if (students[indexStudent].mark.ToString() != "0")
            {
                mark_textBox.Text = students[indexStudent].mark.ToString();
            }
            else
            {
                mark_textBox.Text = "Не оценено";
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_answer.Text != "")
            {
                students[indexStudent].answer_status = "Сдано";
                students[indexStudent].answer = textBox_answer.Text;
                string json = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText("database.json", json);
                MessageBox.Show("Изменения успешно сохранены", "Уведомление", MessageBoxButtons.OK);
            }
        }
    }
}
