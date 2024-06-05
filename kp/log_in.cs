using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Diagnostics.Eventing.Reader;

namespace kp
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_login.MaxLength = 50;
            label_incorrectLogin.Visible = false;
            label_emptyInput.Visible = false;
        }

        //вызывается при нажатии на кнопку "Войти"
        private void button_login_Click(object sender, EventArgs e)
        {
            //считываем введенный логин
            var loginUser = textBox_login.Text;
            bool loggedIn = false;

            //считываем данные студентов из json-файла
            string json = File.ReadAllText(@"database.json");

            //записываем данные каждого студента в класс student, и добавляем в список студентов
            List<student> students = JsonConvert.DeserializeObject<List<student>>(json);
            int indexStudent = 0;
            foreach (student _student in students)
            {
                //проверяем введенный логин с логином каждого студента из списка
                if (loginUser == _student.login) {
                    loggedIn = true;
                    this.Hide();
                    main m = new main(students, indexStudent);
                    m.ShowDialog();
                    textBox_login.Clear();
                    label_incorrectLogin.Visible = false;
                    label_emptyInput.Visible = false;
                    this.Show();
                }
                indexStudent++;
            }

            //если ничего не ввели, но нажали на кнопку "Войти", выводится сообщение
            if (loginUser == "")
            {
                label_incorrectLogin.Visible = false;
                label_emptyInput.Visible = true;
            }

            //если в приложении авторизуется преподаватель
            else if (loginUser == "teacher1")
            {
                loggedIn = true;
                this.Hide();
                main m = new main(loginUser);
                m.ShowDialog();
                textBox_login.Clear();
                label_incorrectLogin.Visible = false;
                label_emptyInput.Visible = false;
                this.Show();
            }

            //если введен неправильный логин, выводится соответствующее сообщение
            else if (loggedIn == false)
            {
                textBox_login.Clear();
                label_emptyInput.Visible = false;
                label_incorrectLogin.Visible = true;
            }
        }
    }
}