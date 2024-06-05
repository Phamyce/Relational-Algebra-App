using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp
{
    public partial class main : Form
    {
        List<student> students = new List<student>();
        int indexStudent;
        string loginUser = "";
        public main(List<student> _students, int _indexStudent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            students = _students;
            indexStudent = _indexStudent;
        }

        public main(string _loginUser)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            loginUser = _loginUser;
        }
        private void main_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.TopLevel = false;
            if (panelWindow.Controls.Count > 0)
            {
                panelWindow.Controls.Clear();
            }
            panelWindow.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            label_main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        private void panel_main_Click(object sender, EventArgs e)
        {
            label_theory.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_main.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Form1 frm = new Form1();
            frm.TopLevel = false;
            if (panelWindow.Controls.Count > 0)
            {
                panelWindow.Controls.Clear();
            }
            panelWindow.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void panel_theory_Click(object sender, EventArgs e)
        {
            label_main.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_theory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            theory th = new theory();
            th.TopLevel = false;
            if (panelWindow.Controls.Count > 0)
            {
                panelWindow.Controls.Clear();
            }
            panelWindow.Controls.Add(th);
            th.BringToFront();
            th.Show();
        }

        private void panel_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && loginUser == "")
            {
                tasks t = new tasks(students, indexStudent);
                t.ShowDialog();
            }
            if (e.KeyCode == Keys.E && loginUser != "")
            {
                teacher_editor ed = new teacher_editor(students, indexStudent);
                ed.ShowDialog();
            }
        }
    }
}
