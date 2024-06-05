using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Diagnostics.Eventing.Reader;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace kp
{
    public partial class Form1 : Form
    {
        //список для хранения таблиц с данными
        List<DataGridView> list_dgw = new List<DataGridView>();

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //чтение таблиц с данными из json-файлов
            string jsonString_employee = File.ReadAllText(@"employee.json");
            employee.DataSource = JsonConvert.DeserializeObject<DataTable>(jsonString_employee);
            string jsonString_provider = File.ReadAllText(@"provider.json");
            provider.DataSource = JsonConvert.DeserializeObject<DataTable>(jsonString_provider);
            list_dgw.Add(employee);
            list_dgw.Add(provider);

            //создание плашки с информацией resetButtonToolTip, которая появляется при наведении
            //на кнопку очистки окна вывода
            var resetButtonToolTip = new ToolTip();
            resetButtonToolTip.SetToolTip(button_reset, "Очистить окно запроса");
        }

        //функция для очистки окна вывода
        private void button_reset_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_result.Controls.Clear();
            int new_cnt_list_dgw = list_dgw.Count - 2;
            int new_cnt_list_dgw_names = list_dgw.Count - 2;
            //удаляем все таблицы, кроме тех двух,
            //которые используются для создания запроса
            list_dgw.RemoveRange(2, new_cnt_list_dgw);
        }

        private DataGridView DataGridView_create()
        {
            DataGridView temp = new DataGridView();
            //изменение стиля datagridview: цвет, шрифт, размер колонок
            temp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            temp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            temp.RowHeadersVisible = false;
            temp.Font = new Font("Segoe UI", 9);
            return temp;
        }

        private Label Label_create()   
        {
            Label l = new Label();
            //изменение стиля label: размер элемента, шрифт, цвет
            l.Size = new System.Drawing.Size(581, 30);
            l.Font = new Font("Segoe UI", 11);
            l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            return l;
        }

        //функция для вывода запроса в окно вывода
        private void createResult(string queryText, DataTable dt)
        {
            if (dt.Rows.Count != 0)
            {
                //создание объекта datagridview,
                //который отображает данные на форме
                DataGridView temp = DataGridView_create();
                temp.Name = queryText;
                temp.DataSource = dt;

                //создание текста запроса
                Label l = Label_create();
                l.Text = queryText;

                //добавление datagridview и label на окно вывода
                flowLayoutPanel_result.Controls.Add(l);
                flowLayoutPanel_result.Controls.Add(temp);
                list_dgw.Add(temp);
            }
        }

        //функция для создания проекции
        private void button_projection_Click(object sender, EventArgs e)
        {
            projection prj = new projection(list_dgw);
            prj.ShowDialog();
            createResult(prj.get_projectionName(), prj.get_DataTable());
        }

        private void button_selection_Click(object sender, EventArgs e)
        {
            selection sel = new selection(list_dgw);
            sel.ShowDialog();
            createResult(sel.get_selectionName(), sel.get_DataTable());
        }

        private void button_union_Click(object sender, EventArgs e)
        {
            union un = new union(list_dgw);
            un.ShowDialog();
            createResult(un.get_unionName(), un.get_DataTable());
        }

        private void button_intersection_Click(object sender, EventArgs e)
        {
            intersection i = new intersection(list_dgw);
            i.ShowDialog();
            createResult(i.get_intersectionName(), i.get_DataTable());
        }

        private void button_exception_Click(object sender, EventArgs e)
        {
            exception ex = new exception(list_dgw);
            ex.ShowDialog();
            createResult(ex.get_exceptionName(), ex.get_DataTable());
        }

        private void button_cross_join_Click(object sender, EventArgs e)
        {
            crossjoin crs = new crossjoin(list_dgw);
            crs.ShowDialog();
            createResult(crs.get_crossjoinName(), crs.get_DataTable());
        }

        private void button_natural_join_Click(object sender, EventArgs e)
        {
            naturaljoin n = new naturaljoin(list_dgw);
            n.ShowDialog();
            createResult(n.get_naturaljoinName(), n.get_DataTable());
        }

        private void button_leftjoin_Click(object sender, EventArgs e)
        {
            leftjoin lj = new leftjoin(list_dgw);
            lj.ShowDialog();
            createResult(lj.get_leftjoinName(), lj.get_DataTable());
        }

        private void button_rightjoin_Click(object sender, EventArgs e)
        {
            rightjoin rj = new rightjoin(list_dgw);
            rj.ShowDialog();
            createResult(rj.get_rightjoinName(), rj.get_DataTable());
        }

    }
}