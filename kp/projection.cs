using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kp
{
    public partial class projection : Form
    {
        //список с таблицами
        List<DataGridView> dgw = new List<DataGridView>();
        //список, в который передаётся выбранная таблица и атрибуты таблицы
        List<int> cb = new List<int>();
        public projection(List<DataGridView> dgww)
        {
            InitializeComponent();
            dgw = dgww;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //загрузка таблиц, в элементы формы
        private void projection_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgw.Count; i++)
            {
                comboBox_tables.Items.Add(dgw[i].Name);
            }
            checkedListBox_columns.Enabled = false;
        }

        //функция, в которой мы передаем индексы выбранной таблицу и атрибутов в список cb
        private void button_ok_Click(object sender, EventArgs e)
        {
            if (comboBox_tables.SelectedIndex != -1 && checkedListBox_columns.CheckedIndices.Count != 0)
            {
                cb.Add(comboBox_tables.SelectedIndex);
                for (int i = 0; i < checkedListBox_columns.CheckedIndices.Count; i++)
                {
                    cb.Add(checkedListBox_columns.CheckedIndices[i]);
                }
                this.Close();
            }

            //если не выбрали таблицу, то цвет label_tables("Выберите отношение") становится красным
            else if (comboBox_tables.SelectedIndex == -1)
            {
                label_tables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }

            //если не выбрали таблицу, то цвет label_columns("Выберите атрибут отношения") становится красным
            else if (checkedListBox_columns.CheckedIndices.Count == 0)
            {
                label_columns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        //функция для создания текста запроса
        private string projectionName_create()
        {
            string projection_name = "π (";
            if (cb.Count == 2)
            {
                projection_name += dgw[cb[0]].Name;
                projection_name += ".";
                projection_name += dgw[cb[0]].Columns[cb[1]].Name;
                projection_name += ")";
            }
            else
            {
                for (int i = 1; i < cb.Count; i++)
                {
                    projection_name += dgw[cb[0]].Name;
                    projection_name += ".";
                    projection_name += dgw[cb[0]].Columns[cb[i]].Name;
                    if (cb.Count - i != 1)
                    {
                        projection_name += ", ";
                    }
                }
                projection_name += ")";
            }
            return projection_name;
        }

        public string get_projectionName()
        {
            return this.projectionName_create();
        }

        //функция для создания запроса на LINQ
        private DataTable projectionQuery() {
            DataTable dt_res = new DataTable();
            if (cb.Count != 0)
            {
                DataTable dt = (DataTable)dgw[cb[0]].DataSource;
                List<string> columnsName = new List<string>();
                for (int i = 1; i < cb.Count; i++)
                {
                    string selectedcolName = dgw[cb[0]].Columns[cb[i]].Name;
                    //добавление названий выбранных атрибутов
                    columnsName.Add(selectedcolName);
                }

                //создание проекции
                dt_res = new DataView(dt).ToTable(false, columnsName.ToArray());
            }
            return dt_res;
        }

        public DataTable get_DataTable()
        {
            return this.projectionQuery();
        }

        private void comboBox_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resultIndex = comboBox_tables.SelectedIndex;
            if (resultIndex != -1)
            {
                label_tables.ForeColor = SystemColors.ControlText;
                checkedListBox_columns.Items.Clear();
                checkedListBox_columns.Enabled = true;
                for (int i = 0; i < dgw[resultIndex].Columns.Count; i++)
                {
                    checkedListBox_columns.Items.Add(dgw[resultIndex].Columns[i].HeaderText);
                }
            }
        }

        private void checkedListBox_columns_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_columns.ForeColor = SystemColors.ControlText;
        }
    }
}
