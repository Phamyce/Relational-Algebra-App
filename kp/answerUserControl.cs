using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp
{
    public partial class answerUserControl : UserControl
    {
        List<student> students = new List<student>();
        int indexStudent;
        string last_name;
        string first_name;
        string patronymic;
        string answer_status;
        string Answer;
        int mark;
        public answerUserControl(List<student> _students, int _indexStudent,string _last_name, string _first_name, string _patronymic, string _answer_status, string _Answer, int _mark)
        {
            InitializeComponent();
            students = _students;
            indexStudent = _indexStudent;
            last_name = _last_name;
            first_name = _first_name;
            patronymic = _patronymic;
            Answer = _Answer;
            answer_status = _answer_status;
            mark = _mark;
        }

        private void answerUserControl_Load(object sender, EventArgs e)
        {
            fio_toolStripStatusLabel.Text = last_name + " " + first_name + " " + patronymic;
            answer_status_toolStripStatusLabel.Text = answer_status;
            if (answer_status_toolStripStatusLabel.Text == "Не сдано")
            {
                answer_status_toolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
            else if (answer_status_toolStripStatusLabel.Text == "Сдано")
            {
                answer_status_toolStripStatusLabel.ForeColor = System.Drawing.Color.ForestGreen;
            }
            if (mark.ToString() != "0")
            {
                mark_toolStripStatusLabel.Text = mark.ToString();
            }
        }

        private void button_see_answer_Click(object sender, EventArgs e)
        {
            //создание формы, в которой преподаватель может оценить ответ студента
            answer ans = new answer(students, indexStudent, last_name, first_name, patronymic, Answer);
            ans.ShowDialog();
        }
    }
}
