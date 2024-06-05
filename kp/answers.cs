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
    public partial class answers : Form
    {
        List<student> students = new List<student>();
        int indexStudent;
        public answers(List<student> _students, int _indexStudent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            students = _students;
            indexStudent = _indexStudent;
        }

        private void answers_Load(object sender, EventArgs e)
        {
            //загрузка данных студентов из файла
            string json = File.ReadAllText(@"database.json");
            List<student> students = JsonConvert.DeserializeObject<List<student>>(json);
            foreach (student _student in students) {
                //создание объекта, который выводит информацию о студенте: фио,статус сдачи работы, оценка
                answerUserControl temp = new answerUserControl(students, indexStudent, _student.last_name, _student.first_name, _student.patronymic, _student.answer_status, _student.answer, _student.mark);
                answersflowLayout.Controls.Add(temp);
            }
        }
    }
}
