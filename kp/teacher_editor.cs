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
    public partial class teacher_editor : Form
    {
        List<student> students = new List<student>();
        int indexStudent;
        public teacher_editor(List<student> _students, int _indexStudent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            students = _students;
            indexStudent = _indexStudent;
        }

        private void teacher_editor_Load(object sender, EventArgs e)
        {
            answers frm = new answers(students, indexStudent);
            frm.TopLevel = false;
            if (panelWindow.Controls.Count > 0)
            {
                panelWindow.Controls.Clear();
            }
            panelWindow.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            label_answers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        private void panel_answers_Click(object sender, EventArgs e)
        {
            label_editor.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_answers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            answers frm = new answers(students, indexStudent);
            frm.TopLevel = false;
            if (panelWindow.Controls.Count > 0)
            {
                panelWindow.Controls.Clear();
            }
            panelWindow.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void panel_editor_Click(object sender, EventArgs e)
        {
            label_answers.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label_editor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            editor th = new editor();
            th.TopLevel = false;
            if (panelWindow.Controls.Count > 0)
            {
                panelWindow.Controls.Clear();
            }
            panelWindow.Controls.Add(th);
            th.BringToFront();
            th.Show();
        }
    }
}
